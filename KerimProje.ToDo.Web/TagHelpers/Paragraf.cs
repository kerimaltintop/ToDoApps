using Microsoft.AspNetCore.Razor.TagHelpers;

namespace KerimProje.ToDo.Web.TagHelpers
{
    [HtmlTargetElement("kerim")]
    public class Paragraf : TagHelper
    {
        public string getData { get; set; } = "Kerim ALTINTOP";
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string data = string.Empty;
            data = "<p> <b>" + getData + " </b> </p>";
            output.Content.SetHtmlContent(data);
            base.Process(context, output);
        }

    }
}
