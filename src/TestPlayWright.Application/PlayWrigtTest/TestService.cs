using ClosedXML.Excel;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using DocumentFormat.OpenXml.Presentation;

namespace TestPlayWright.PlayWrigtTest
{
    public class TestService : TestPlayWrightAppService
    {
        public TestService()
        {

        }

        public async Task<string> CheckAsync(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return "File is not provided or empty.";
            }

            using var workbook = new XLWorkbook(file.OpenReadStream());
            int startIndex = file.FileName.IndexOf("HRMS");

            // Kiểm tra xem phần cần lấy có tồn tại không
            if (startIndex != -1)
            {
                // Tìm vị trí kết thúc của phần cần lấy
                int endIndex = file.FileName.IndexOf("_", startIndex);

                // Lấy phần cần lấy từ chuỗi
                string part = file.FileName.Substring(startIndex, endIndex - startIndex);
            }
            var worksheet = workbook.Worksheets.FirstOrDefault(
                ws => ws.Name.Contains("項目", StringComparison.OrdinalIgnoreCase) && !ws.Name.Contains("VN", StringComparison.OrdinalIgnoreCase));

            // Kiểm tra xem worksheet có tồn tại không
            if (worksheet != null)
            {
                for (int i = 2; i <= 6; i++)
                {
                    for (int j = 13; j <= worksheet.RowCount(); j++)
                    {
                        var cell = worksheet.Cell(j, i);
                        var valueIndex = cell.Value;
                        var nextCell = worksheet.Cell(j, i + 1);
                        var valueName = nextCell.Value;
                        if (!valueIndex.IsBlank && !valueIndex.IsNumber)
                        {
                            continue;
                        }
                        if (valueName.ToString().Contains("メッ"))
                        {
                            continue;
                        }
                        bool hasBorder = cell.Style.Border.TopBorder != XLBorderStyleValues.None &&
                             cell.Style.Border.BottomBorder != XLBorderStyleValues.None &&
                             cell.Style.Border.LeftBorder != XLBorderStyleValues.None &&
                             cell.Style.Border.RightBorder != XLBorderStyleValues.None;

                        if (hasBorder)
                        {
                            var a = String.Empty;
                        }
                        else
                        {
                            return $"Dòng {j} không có border.";
                        }
                        break;
                    }
                }
                return worksheet.Name;

                // Thực hiện các thao tác khác trên worksheet nếu cần
            }
            else
            {
                return "Không tìm thấy worksheet phù hợp.";
            }
            // Process the file here (e.g., save it to disk, manipulate it, etc.)

            return "File uploaded successfully.";
        }
    }
}
