#pragma checksum "/Users/user/steelAuth/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2dd63a8b54ee54e7697542217398a53af78ef9ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(steelAuth.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace steelAuth.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "/Users/user/steelAuth/Pages/_ViewImports.cshtml"
using steelAuth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/user/steelAuth/Pages/_ViewImports.cshtml"
using steelAuth.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/user/steelAuth/Pages/Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dd63a8b54ee54e7697542217398a53af78ef9ac", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e7ffa703954926c3ed0d1e08359a71968b51bcf", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/chat.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "/Users/user/steelAuth/Pages/Index.cshtml"
  
    ViewData["Title"] = "cChat";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">

<style>




    #drop-area {
        border: 2px dashed #ccc;
        border-radius: 20px;
        width: 100%;
        font-family: sans-serif;
        margin: auto auto;
        padding: 20px;
        height: auto;
    }

        #drop-area.highlight {
            border-color: purple;
        }

    p {
        margin-top: 0;
    }

    .my-form {
        margin-bottom: 10px;
    }

    #gallery {
        margin-top: 10px;
    }

        #gallery img {
            width: 150px;
            margin-bottom: 10px;
            margin-right: 10px;
            vertical-align: middle;
        }

    .button {
        display: inline-block;
        padding: 10px;
        background: #ccc;
        color: aquamarine;
        cursor: pointer;
        border-radius: 5px;
        border: 1px solid #ccc;
    }

        .button:hover {
            backgroun");
            WriteLiteral(@"d: #ddd;
            color: aquamarine;
        }

    #fileElem {
        display: none;
    }

    .btn {
        position: relative;
        background-color: white;
        border: none;
        color: grey;
        right: 100%-30px;
        width: 65px;
        height: 95%;
        min-height: 25px;
        min-width: 65px;
        margin-bottom: 4%;
        margin-left: 0%;
        margin-right: 15%;
        cursor: pointer;
        font-size: 18px;
    }

    .btn-primary {
        background-color: white;
        color: #fff;
        border-color: #1861ac;
    }

    .from-me {
        position: relative;
        padding: 10px 10px;
        color: black;
        background: #0B93F6;
        border-radius: 25px 25px 0 25px;
        float: right;
        font-size: 12px;
        margin-top: 5px;
        margin-bottom: 5px;
        word-wrap: break-word;
        white-space: pre-line;
        max-width: 100%;
    }

    .from-me-twice {
        position: rel");
            WriteLiteral(@"ative;
        padding: 10px 10px;
        color: black;
        background: #0B93F6;
        border-radius: 25px 0px 0 25px;
        float: right;
        font-size: 12px;
        margin-top: -18px;
        margin-bottom: 5px;
        word-wrap: break-word;
        white-space: pre-line;
        max-width: 100%;
    }

    .from-them {
        position: relative;
        padding: 10px 10px;
        color: black;
        background: #E5E5EA;
        border-radius: 25px 25px 25px 0;
        float: left;
        font-size: 12px;
        margin-top: 5px;
        margin-bottom: 5px;
        word-wrap: break-word;
        white-space: pre-line;
        max-width: 100%;
    }
    .from-them-twice {
        position: relative;
        padding: 10px 10px;
        color: black;
        background: #E5E5EA;
        border-radius: 0px 25px 25px 0;
        float: left;
        font-size: 12px;
        margin-top: -18px;
        margin-bottom: 5px;
        word-wrap: break-word;
    ");
            WriteLiteral(@"    white-space: pre-line;
        max-width: 100%;
    }

    .footer {
        left: 0;
        position: fixed;
        bottom: 0px;
        height: 45px;
        width: 100%;
        min-width: 70px;
    }

    .txtarea {
        background-color: #f6f6f6;
        display: inline-block;
        box-shadow: inset 2px 2px 5px rgba(154, 147, 140, 0.5), 1px 1px 5px rgba(255, 255, 255, 1);
        border-radius: 10px 10px 10px 10px;
        line-height: 1.5em;
        margin-left: 10%;
        resize: none;
        outline: none;
        text-align: center;
        align-items: center;
        align-self: center;
        border: none;
        width: 80%;
        min-width: 150px;
        height: 100%;
        border: 2px dashed #ccc;
        padding: 20px;
    }

    .message {
        word-wrap: break-word;
        white-space: pre-line;
    }

    #arrowTop {
        height: 9px;
        width: 14px;
        color: green;
        position: fixed;
        top: 10px;
            WriteLiteral(@"
        left: 10px;
        cursor: pointer;
    }

        #arrowTop::before {
            content: '▲';
        }
</style>

<div style=""position:fixed""><input type=""text"" id=""userInput"" value=""defaultuser"" style=""visibility:hidden"" /></div>

<h1>");
#nullable restore
#line 202 "/Users/user/steelAuth/Pages/Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div id=\"arrowTop\" hidden></div>\r\n");
#nullable restore
#line 205 "/Users/user/steelAuth/Pages/Index.cshtml"
 if (SignInManager.IsSignedIn(User))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <textarea id=\"hiddenName\" hidden>");
#nullable restore
#line 207 "/Users/user/steelAuth/Pages/Index.cshtml"
                                Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n    <textarea id=\"hiddenStatus\" hidden>Empty</textarea>\r\n");
#nullable restore
#line 209 "/Users/user/steelAuth/Pages/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>arrowTop.onclick = function () {
        window.scrollTo(pageXOffset, 0);
    };

    window.addEventListener('scroll', function () {
        arrowTop.hidden = (pageYOffset < document.documentElement.clientHeight);
    });</script>

<table id=""drop-areaTable"" style=""width:100%; border:none; max-width: 100%"">
    <tbody id=""drop-area"" class=""drop-area"" style=""width:100%; border:none; max-width: 100%;"">
    </tbody>
</table>

");
#nullable restore
#line 223 "/Users/user/steelAuth/Pages/Index.cshtml"
 if (SignInManager.IsSignedIn(User))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""footer"">
        <div style=""width:100%-80px; height:100%"">
            <textarea id=""messageInput"" class=""txtarea"" autofocus placeholder=""Type some message...""></textarea>
        </div>
        <div style=""width:80px; height:100%; left:100%-80px"">
            <button class=""btn"" id=""sendButton""><i class=""fa fa-send fa-3x""></i></button>
        </div>
    </div>
");
#nullable restore
#line 233 "/Users/user/steelAuth/Pages/Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""footer"">
        <div style=""width:100%-80px; height:100%"">
            <textarea id=""messageInput"" class=""txtarea"" autofocus placeholder=""You are not authorized"" readonly></textarea>
        </div>
        <div style=""width:80px; height:100%; left:100%-80px"">
            <button class=""btn"" id=""sendButton""><i class=""fa fa-send fa-3x""></i></button>
        </div>
    </div>
");
#nullable restore
#line 244 "/Users/user/steelAuth/Pages/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2dd63a8b54ee54e7697542217398a53af78ef9ac11107", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2dd63a8b54ee54e7697542217398a53af78ef9ac12133", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script></script>

<script>//let dropArea = document.getElementById('drop-area')

//        ;['dragenter', 'dragover', 'dragleave', 'drop'].forEach(eventName => {
//            dropArea.addEventListener(eventName, preventDefaults, false)
//        })
//    function preventDefaults(e) {
//        e.preventDefault()
//        e.stopPropagation()
//    }

//    ;['dragenter', 'dragover'].forEach(eventName => {
//        dropArea.addEventListener(eventName, highlight, false)
//    })
//        ;['dragleave', 'drop'].forEach(eventName => {
//            dropArea.addEventListener(eventName, unhighlight, false)
//        })
//    function highlight(e) {
//        dropArea.classList.add('highlight')
//    }
//    function unhighlight(e) {
//        dropArea.classList.remove('highlight')
//    }

//    dropArea.addEventListener('drop', handleDrop, false)
//    function handleDrop(e) {
//        let dt = e.dataTransfer
//        let files = dt.files
//        handleFiles(files)
//    }
");
            WriteLiteral(@"
//    function handleFiles(files) {
//        ([...files]).forEach(uploadFile)
//    }

//    var apiUrl = 'https://api.imgur.com/3/image';
//    var apiKey = 'ctrlq';

//    function uploadFile(file) {

//        var settings = {
//            async: false,
//            crossDomain: true,
//            processData: false,
//            contentType: false,
//            type: 'POST',
//            url: apiUrl,
//            headers: {
//                Authorization: 'dc8eb9334cdc451' + ""34caae4a42ea766ce40cdcc9f9fccbce5feda64f"",
//                Accept: 'application/json'
//            },
//            mimeType: 'multipart/form-data'
//        };

//        var formData = new FormData();
//        formData.append(""file"", $files[0]);
//        settings.data = formData;

//        // Response contains stringified JSON
//        // Image URL available at response.data.link

//        $.ajax(settings).done(function (response) {
//            console.log(response);
//        });

        //let url");
            WriteLiteral(@" = ''
        //let formData = new FormData()
        //formData.append('file', file)
        //fetch(url, {
        //    method: 'POST',
        //    body: formData
        //})
        //    .then(() => { alert(""Успех""); })
        //    .catch(() => { alert(""Ошибка""); })
  //  }

    </script>

<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
<script>
    //var imgfile = (""https://htmlforum.io/uploads/monthly_2017_09/M.png.e3bfaf846fe94d6aa8b814f526f60b92.png"").val();

    //var formData = new FormData()
    //formData.append('file', ""https://htmlforum.io/uploads/monthly_2017_09/M.png.e3bfaf846fe94d6aa8b814f526f60b92.png"")
    //$.ajax({
    //    url: ""https://api.imgur.com/3/upload"",
    //    type: ""POST"",
    //    datatype: ""json"",
    //    headers: { ""Authorization"": ""Client-ID dc8eb9334cdc451"", ""Access-Control-Allow-Origin"": """" },
    //    data: { image: ""file"" },
    //    success: {},
    //    error: {},
    //});

    //if (!file || !fi");
            WriteLiteral(@"le.type.match(/image.*/)) return;

    // Это оно!
    // Создаём объект FormData
    var images = new File(""https://htmlforum.io/uploads/monthly_2017_09/M.png.e3bfaf846fe94d6aa8b814f526f60b92.png"");
    var fd = new FormData();
    fd.append(""image"", images); // Append the file

    fd.append(""key"", ""0062e4eaf8fc363d711497d3a359c63bb207c6c1"");

    // Получите собственный ключ: http://api.imgur.com/

    // Сделайте XHR (Cross-Domain XH, чёрт побери!!!)
    var xhr = new XMLHttpRequest();
    xhr.open(""POST"", ""http://api.imgur.com/2/upload.json""); // Boooom!
    xhr.onload = function () {
        // Победа!
        // URL изображения:
        JSON.parse(xhr.responseText).upload.links.imgur_page;
    }
    // Я не рассматривал ошибки, чтобы пример был короче.
    // А сейчас отправляем formdata

    xhr.send(fd);

</script>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591