#pragma checksum "C:\Users\FIO\source\repos\N00029793EF\N00029793EF\Views\NoteU\NaTog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c61c17671597d803b67364b546ce0c68c0eeab2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NoteU_NaTog), @"mvc.1.0.view", @"/Views/NoteU/NaTog.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\FIO\source\repos\N00029793EF\N00029793EF\Views\_ViewImports.cshtml"
using N00029793EF;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FIO\source\repos\N00029793EF\N00029793EF\Views\_ViewImports.cshtml"
using N00029793EF.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c61c17671597d803b67364b546ce0c68c0eeab2", @"/Views/NoteU/NaTog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d07a0b412d00aa663139f6984858399ab1e61c4", @"/Views/_ViewImports.cshtml")]
    public class Views_NoteU_NaTog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\FIO\source\repos\N00029793EF\N00029793EF\Views\NoteU\NaTog.cshtml"
  
    
    var tages = (List<TagNote>)Model;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <a href=""/NoteU/index"" style=""margin-left:20px;"" class=""btn btn-outline-dark float-lg-right"">
        <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-arrow-bar-left"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
            <path fill-rule=""evenodd"" d=""M12.5 15a.5.5 0 0 1-.5-.5v-13a.5.5 0 0 1 1 0v13a.5.5 0 0 1-.5.5zM10 8a.5.5 0 0 1-.5.5H3.707l2.147 2.146a.5.5 0 0 1-.708.708l-3-3a.5.5 0 0 1 0-.708l3-3a.5.5 0 1 1 .708.708L3.707 7.5H9.5a.5.5 0 0 1 .5.5z"" />
        </svg>
    </a>
</div>
<br />
<br />
");
#nullable restore
#line 15 "C:\Users\FIO\source\repos\N00029793EF\N00029793EF\Views\NoteU\NaTog.cshtml"
 foreach (var item in tages)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container-fluid\">\r\n        <ul class=\"list-group\">\r\n            <li class=\"list-group-item text-black-50\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 777, "\"", 815, 2);
            WriteAttributeValue("", 784, "/NoteU/Detalle?Id=", 784, 18, true);
#nullable restore
#line 20 "C:\Users\FIO\source\repos\N00029793EF\N00029793EF\Views\NoteU\NaTog.cshtml"
WriteAttributeValue("", 802, item.note.Id, 802, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                    <strong>
                        <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-journal-text"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                            <path d=""M3 0h10a2 2 0 0 1 2 2v12a2 2 0 0 1-2 2H3a2 2 0 0 1-2-2v-1h1v1a1 1 0 0 0 1 1h10a1 1 0 0 0 1-1V2a1 1 0 0 0-1-1H3a1 1 0 0 0-1 1v1H1V2a2 2 0 0 1 2-2z"" />
                            <path d=""M1 5v-.5a.5.5 0 0 1 1 0V5h.5a.5.5 0 0 1 0 1h-2a.5.5 0 0 1 0-1H1zm0 3v-.5a.5.5 0 0 1 1 0V8h.5a.5.5 0 0 1 0 1h-2a.5.5 0 0 1 0-1H1zm0 3v-.5a.5.5 0 0 1 1 0v.5h.5a.5.5 0 0 1 0 1h-2a.5.5 0 0 1 0-1H1z"" />
                            <path fill-rule=""evenodd"" d=""M5 10.5a.5.5 0 0 1 .5-.5h2a.5.5 0 0 1 0 1h-2a.5.5 0 0 1-.5-.5zm0-2a.5.5 0 0 1 .5-.5h5a.5.5 0 0 1 0 1h-5a.5.5 0 0 1-.5-.5zm0-2a.5.5 0 0 1 .5-.5h5a.5.5 0 0 1 0 1h-5a.5.5 0 0 1-.5-.5zm0-2a.5.5 0 0 1 .5-.5h5a.5.5 0 0 1 0 1h-5a.5.5 0 0 1-.5-.5z"" />
                        </svg>  ");
#nullable restore
#line 26 "C:\Users\FIO\source\repos\N00029793EF\N00029793EF\Views\NoteU\NaTog.cshtml"
                           Write(item.note.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </strong>\r\n                </a>\r\n\r\n                <span>\r\n                    <br />\r\n");
#nullable restore
#line 32 "C:\Users\FIO\source\repos\N00029793EF\N00029793EF\Views\NoteU\NaTog.cshtml"
                     if (item.note.Contenido.Length > 50)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <parcial>");
#nullable restore
#line 34 "C:\Users\FIO\source\repos\N00029793EF\N00029793EF\Views\NoteU\NaTog.cshtml"
                            Write(item.note.Contenido.Substring(0, 50));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ...</parcial> ");
#nullable restore
#line 34 "C:\Users\FIO\source\repos\N00029793EF\N00029793EF\Views\NoteU\NaTog.cshtml"
                                                                                     }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <parcial>");
#nullable restore
#line 37 "C:\Users\FIO\source\repos\N00029793EF\N00029793EF\Views\NoteU\NaTog.cshtml"
                            Write(item.note.Contenido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</parcial>");
#nullable restore
#line 37 "C:\Users\FIO\source\repos\N00029793EF\N00029793EF\Views\NoteU\NaTog.cshtml"
                                                               }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </span>\r\n\r\n                <div align=\"right\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2262, "\"", 2301, 2);
            WriteAttributeValue("", 2269, "/NoteU/Eliminar?id=", 2269, 19, true);
#nullable restore
#line 41 "C:\Users\FIO\source\repos\N00029793EF\N00029793EF\Views\NoteU\NaTog.cshtml"
WriteAttributeValue("", 2288, item.note.Id, 2288, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""margin-left:20px;"" class=""btn btn-danger float-lg-right"">
                        <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-trash-fill"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                            <path fill-rule=""evenodd"" d=""M2.5 1a1 1 0 0 0-1 1v1a1 1 0 0 0 1 1H3v9a2 2 0 0 0 2 2h6a2 2 0 0 0 2-2V4h.5a1 1 0 0 0 1-1V2a1 1 0 0 0-1-1H10a1 1 0 0 0-1-1H7a1 1 0 0 0-1 1H2.5zm3 4a.5.5 0 0 1 .5.5v7a.5.5 0 0 1-1 0v-7a.5.5 0 0 1 .5-.5zM8 5a.5.5 0 0 1 .5.5v7a.5.5 0 0 1-1 0v-7A.5.5 0 0 1 8 5zm3 .5a.5.5 0 0 0-1 0v7a.5.5 0 0 0 1 0v-7z"" />
                        </svg>
                    </a>
                    <button id=""editModal"" style=""margin-right:20px;"" class=""btn btn-light float-lg-right"" href=""#"" data-toggle=""modal"" data-target=""#edit""");
            BeginWriteAttribute("onclick", " onclick=\"", 3099, "\"", 3176, 7);
            WriteAttributeValue("", 3109, "selCuenta(", 3109, 10, true);
#nullable restore
#line 46 "C:\Users\FIO\source\repos\N00029793EF\N00029793EF\Views\NoteU\NaTog.cshtml"
WriteAttributeValue("", 3119, item.note.Id, 3119, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3132, ",\'", 3132, 2, true);
#nullable restore
#line 46 "C:\Users\FIO\source\repos\N00029793EF\N00029793EF\Views\NoteU\NaTog.cshtml"
WriteAttributeValue("", 3134, item.note.Titulo, 3134, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3151, "\',\'", 3151, 3, true);
#nullable restore
#line 46 "C:\Users\FIO\source\repos\N00029793EF\N00029793EF\Views\NoteU\NaTog.cshtml"
WriteAttributeValue("", 3154, item.note.Contenido, 3154, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3174, "\')", 3174, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
                        <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-pencil-square"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                            <path d=""M15.502 1.94a.5.5 0 0 1 0 .706L14.459 3.69l-2-2L13.502.646a.5.5 0 0 1 .707 0l1.293 1.293zm-1.75 2.456l-2-2L4.939 9.21a.5.5 0 0 0-.121.196l-.805 2.414a.25.25 0 0 0 .316.316l2.414-.805a.5.5 0 0 0 .196-.12l6.813-6.814z"" />
                            <path fill-rule=""evenodd"" d=""M1 13.5A1.5 1.5 0 0 0 2.5 15h11a1.5 1.5 0 0 0 1.5-1.5v-6a.5.5 0 0 0-1 0v6a.5.5 0 0 1-.5.5h-11a.5.5 0 0 1-.5-.5v-11a.5.5 0 0 1 .5-.5H9a.5.5 0 0 0 0-1H2.5A1.5 1.5 0 0 0 1 2.5v11z"" />
                        </svg>
                    </button>
                </div>
            </li>
        </ul>
        <br />
    </div>
");
#nullable restore
#line 57 "C:\Users\FIO\source\repos\N00029793EF\N00029793EF\Views\NoteU\NaTog.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""modal fade"" id=""edit"" tabindex=""-1"" aria-labelledby=""edit"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title text-black-50"" id=""exampleModalLabel"">
                    <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-pencil-square"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                        <path d=""M15.502 1.94a.5.5 0 0 1 0 .706L14.459 3.69l-2-2L13.502.646a.5.5 0 0 1 .707 0l1.293 1.293zm-1.75 2.456l-2-2L4.939 9.21a.5.5 0 0 0-.121.196l-.805 2.414a.25.25 0 0 0 .316.316l2.414-.805a.5.5 0 0 0 .196-.12l6.813-6.814z"" />
                        <path fill-rule=""evenodd"" d=""M1 13.5A1.5 1.5 0 0 0 2.5 15h11a1.5 1.5 0 0 0 1.5-1.5v-6a.5.5 0 0 0-1 0v6a.5.5 0 0 1-.5.5h-11a.5.5 0 0 1-.5-.5v-11a.5.5 0 0 1 .5-.5H9a.5.5 0 0 0 0-1H2.5A1.5 1.5 0 0 0 1 2.5v11z"" />
                    </svg>  Editar Nota
                </h5>
                <button type=""bu");
            WriteLiteral(@"tton"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" id=""editNotita"">
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancelar</button>
                <button type=""button"" class=""btn btn-primary"" onclick=""submitForm()"">Guardar</button>
            </div>
        </div>
    </div>
</div>


<script>
    function selCuenta(id, titulo, contenido) {
        $('#mtxtId').val(id);
        $('#mtxtTitulo').val(titulo);
        $('#mtxtContenido').val(contenido);
    };

    $.ajax({
        url: '/NoteU/Edit',
        type: 'get'
    }).done(function (html) {
        $('#editNotita').html(html);
    })

    function submitForm() {
        $('#editNota').submit();
    }

    function editar(event) {
        event.preventDefault();
        var");
            WriteLiteral(@" dataString = new FormData($('#edit form')[0]);
        $.ajax({
            url: ""/NoteU/Edit"",
            type: ""post"",
            processData: false,  // Important!
            contentType: false,
            cache: false,
            data: dataString
        }).done(function (html) {
            location.reload();
        }).fail(function (html) {
            $('#editNotita').html(html.responseText);
        });
    }
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
