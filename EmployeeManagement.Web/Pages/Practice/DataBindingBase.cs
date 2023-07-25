using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Pages.Practice
{
    public class DataBindingBase : ComponentBase
    {
        protected string Name { get; set; } = "Tom";

        protected string Gender { get; set; } = "Male";

        protected string BackgroundColor { get; set; } = "background-color:white";

        protected string Colour { get; set; } = "";

        protected string Description { get; set; } = string.Empty;
    }
}
