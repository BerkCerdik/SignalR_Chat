#pragma checksum "C:\Users\berkc\Desktop\SignalR\SignalR\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "302ecf864453e24cdd458148560b2589e084159c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"302ecf864453e24cdd458148560b2589e084159c", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SignalR.Models.ORM.Entities.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\berkc\Desktop\SignalR\SignalR\Views\Home\Index.cshtml"
   Layout = null; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n\n<!DOCTYPE html>\n\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "302ecf864453e24cdd458148560b2589e084159c3795", async() => {
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>Index</title>\n");
                WriteLiteral("    <script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js\"></script>\n    <script src=\"https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js\"></script>\n");
                WriteLiteral("    <script src=\"https://maxcdn.bootstrapcdn.com/font-awesome/4.4.0/css/font-awesome.min.css\"></script>\n\n    <link href=\"/css/StyleSheet.css\" rel=\"stylesheet\" type=\"text/css\" />\n\n");
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "302ecf864453e24cdd458148560b2589e084159c4643", async() => {
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
                WriteLiteral(@"


    <link href='https://fonts.googleapis.com/css?family=source+sans+pro:400,600,700,300' rel='stylesheet' type='text/css'>

    <script src=""https://use.typekit.net/hoy3lrg.js""></script>
    <script>try { typekit.load({ async: true }); } catch (e) { }</script>
    <link rel='stylesheet prefetch' href='https://cdnjs.cloudflare.com/ajax/libs/meyer-reset/2.0/reset.min.css'>
    <link rel='stylesheet prefetch' href='https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.6.2/css/font-awesome.min.css'>
    <style class=""cp-pen-styles"">
    </style>
    <style>
        .body {
            display: flex;
            align-items: center;
            justify-content: center;
            min-height: 100vh;
            background: #a8c9bc !important;
            font-family: ""proxima-nova"", ""Source Sans Pro"", sans-serif;
            font-size: 1em;
            letter-spacing: 0.1px;
            color: #32465a;
            text-rendering: optimizeLegibility;
            text-shadow: 1px 1px 1px rgba(0, 0, 0, 0.004);
   ");
                WriteLiteral("         -webkit-font-smoothing: antialiased;\n        }\n    </style>\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "302ecf864453e24cdd458148560b2589e084159c7588", async() => {
                WriteLiteral("\n\n\n    <div id=\"frame\">\n        <div id=\"sidepanel\">\n            <div id=\"profile\">\n                <div class=\"wrap\">\n                    <img id=\"profile-img\" src=\"http://emilcarlsson.se/assets/mikeross.png\" class=\"online\"");
                BeginWriteAttribute("alt", " alt=\"", 2232, "\"", 2238, 0);
                EndWriteAttribute();
                WriteLiteral(" />\n                    <p>");
#nullable restore
#line 62 "C:\Users\berkc\Desktop\SignalR\SignalR\Views\Home\Index.cshtml"
                  Write(ViewBag.Username);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n");
                WriteLiteral(@"                    <div id=""status-options"">
                        <ul>
                            <li id=""status-online"" class=""active""><span class=""status-circle""></span> <p>Online</p></li>
                            <li id=""status-away""><span class=""status-circle""></span> <p>Away</p></li>
                            <li id=""status-busy""><span class=""status-circle""></span> <p>Busy</p></li>
                            <li id=""status-offline""><span class=""status-circle""></span> <p>Offline</p></li>
                        </ul>
                    </div>
                </div>
            </div>
            <div id=""search"">
                <label");
                BeginWriteAttribute("for", " for=\"", 3039, "\"", 3045, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa fa-search\" aria-hidden=\"true\"></i></label>\n                <input type=\"text\" placeholder=\"Search contacts...\" />\n            </div>\n            <div id=\"contacts\">\n                <ul>\n");
#nullable restore
#line 90 "C:\Users\berkc\Desktop\SignalR\SignalR\Views\Home\Index.cshtml"
                     foreach (var item in Model)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\berkc\Desktop\SignalR\SignalR\Views\Home\Index.cshtml"
                         if (item.ID.ToString() != ViewBag.loginID)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li class=\"contact\"");
                BeginWriteAttribute("id", " id=\"", 3996, "\"", 4009, 1);
#nullable restore
#line 94 "C:\Users\berkc\Desktop\SignalR\SignalR\Views\Home\Index.cshtml"
WriteAttributeValue("", 4001, item.ID, 4001, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                                <div class=\"wrap\">\n");
#nullable restore
#line 96 "C:\Users\berkc\Desktop\SignalR\SignalR\Views\Home\Index.cshtml"
                                     if (item.OnlineStatus == "online")
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <span class=\"contact-status online\"></span>\n");
#nullable restore
#line 99 "C:\Users\berkc\Desktop\SignalR\SignalR\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
#nullable restore
#line 101 "C:\Users\berkc\Desktop\SignalR\SignalR\Views\Home\Index.cshtml"
                                     if (item.OnlineStatus == "away")
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <span class=\"contact-status away\"></span>\n");
#nullable restore
#line 104 "C:\Users\berkc\Desktop\SignalR\SignalR\Views\Home\Index.cshtml"

                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
#nullable restore
#line 107 "C:\Users\berkc\Desktop\SignalR\SignalR\Views\Home\Index.cshtml"
                                     if (item.OnlineStatus == "busy")
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <span class=\"contact-status busy\"></span>\n");
#nullable restore
#line 110 "C:\Users\berkc\Desktop\SignalR\SignalR\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
#nullable restore
#line 112 "C:\Users\berkc\Desktop\SignalR\SignalR\Views\Home\Index.cshtml"
                                     if (item.OnlineStatus == "offline")
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <span class=\"contact-status offline\"></span>\n");
#nullable restore
#line 115 "C:\Users\berkc\Desktop\SignalR\SignalR\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                    <img src=\"http://emilcarlsson.se/assets/louislitt.png\"");
                BeginWriteAttribute("alt", " alt=\"", 5080, "\"", 5086, 0);
                EndWriteAttribute();
                WriteLiteral(" />\n                                    <div class=\"meta\">\n                                        <p class=\"name\">");
#nullable restore
#line 119 "C:\Users\berkc\Desktop\SignalR\SignalR\Views\Home\Index.cshtml"
                                                   Write(item.Username);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n                                        <p class=\"preview\">You just got LITT up, Mike.</p>\n                                    </div>\n                                </div>\n                            </li>\n");
#nullable restore
#line 124 "C:\Users\berkc\Desktop\SignalR\SignalR\Views\Home\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "C:\Users\berkc\Desktop\SignalR\SignalR\Views\Home\Index.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n");
                WriteLiteral(@"                </ul>
            </div>
            <div id=""bottom-bar"">
                <button id=""addcontact""><i class=""fa fa-user-plus fa-fw"" aria-hidden=""true""></i> <span>Add contact</span></button>
                <button id=""settings""><i class=""fa fa-cog fa-fw"" aria-hidden=""true""></i> <span>Settings</span></button>
            </div>
        </div>
        <div class=""content"">
            <div class=""contact-profile"">
                <img src=""http://emilcarlsson.se/assets/harveyspecter.png""");
                BeginWriteAttribute("alt", " alt=\"", 6563, "\"", 6569, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                <p>Harvey Specter</p>


                <div class=""message-input"">
                    <div class=""wrap"">
                        <input type=""text"" placeholder=""Write your message..."" />
                        <i class=""fa fa-paperclip attachment"" aria-hidden=""true""></i>
                        <button class=""submit""><i class=""fa fa-paper-plane"" aria-hidden=""true""></i></button>
                    </div>
                </div>
            </div>
            <div class=""messages"">
                <ul>
                    <li class=""sent"">
                        <img src=""http://emilcarlsson.se/assets/mikeross.png""");
                BeginWriteAttribute("alt", " alt=\"", 7214, "\"", 7220, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        <p>How the hell am I supposed to get a jury to believe you when I am not even sure that I do?!</p>
                    </li>
                    <li class=""replies"">
                        <img src=""http://emilcarlsson.se/assets/harveyspecter.png""");
                BeginWriteAttribute("alt", " alt=\"", 7497, "\"", 7503, 0);
                EndWriteAttribute();
                WriteLiteral(" />\n                        <p>When you\'re backed against the wall, break the god damn thing down.</p>\n                    </li>\n                    <li class=\"replies\">\n                        <img src=\"http://emilcarlsson.se/assets/harveyspecter.png\"");
                BeginWriteAttribute("alt", " alt=\"", 7756, "\"", 7762, 0);
                EndWriteAttribute();
                WriteLiteral(" />\n                        <p>Excuses don\'t win championships.</p>\n                    </li>\n                    <li class=\"sent\">\n                        <img src=\"http://emilcarlsson.se/assets/mikeross.png\"");
                BeginWriteAttribute("alt", " alt=\"", 7972, "\"", 7978, 0);
                EndWriteAttribute();
                WriteLiteral(" />\n                        <p>Oh yeah, did Michael Jordan tell you that?</p>\n                    </li>\n                    <li class=\"replies\">\n                        <img src=\"http://emilcarlsson.se/assets/harveyspecter.png\"");
                BeginWriteAttribute("alt", " alt=\"", 8206, "\"", 8212, 0);
                EndWriteAttribute();
                WriteLiteral(" />\n                        <p>No, I told him that.</p>\n                    </li>\n                    <li class=\"replies\">\n                        <img src=\"http://emilcarlsson.se/assets/harveyspecter.png\"");
                BeginWriteAttribute("alt", " alt=\"", 8418, "\"", 8424, 0);
                EndWriteAttribute();
                WriteLiteral(" />\n                        <p>What are your choices when someone puts a gun to your head?</p>\n                    </li>\n                    <li class=\"sent\">\n                        <img src=\"http://emilcarlsson.se/assets/mikeross.png\"");
                BeginWriteAttribute("alt", " alt=\"", 8661, "\"", 8667, 0);
                EndWriteAttribute();
                WriteLiteral(" />\n                        <p>What are you talking about? You do what they say or they shoot you.</p>\n                    </li>\n                    <li class=\"replies\">\n                        <img src=\"http://emilcarlsson.se/assets/harveyspecter.png\"");
                BeginWriteAttribute("alt", " alt=\"", 8920, "\"", 8926, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        <p>Wrong. You take the gun, or you pull out a bigger one. Or, you call their bluff. Or, you do any one of a hundred and forty six other things.</p>
                    </li>
                </ul>
            </div>
        </div>
    </div>
");
                WriteLiteral(@"    <script src='https://code.jquery.com/jquery-2.2.4.min.js'></script>
    <script>

        ""use strict"";

        var connection = new signalR.HubConnectionBuilder().withUrl(""/chatHub"").build();


        connection.on(""Receivemessage"", function (message) {
            $('<li class=""sent""><img src=""http://emilcarlsson.se/assets/mikeross.png"" alt="""" /><p>' + message + '</p></li>').appendTo($('.messages ul'));
            $('.message-input input').val(null);
            $('.contact.active .preview').html('<span>You: </span>' + message);
            $("".messages"").animate({ scrollTop: $(document).height() }, ""fast"");
            //$(""body"").css(""background-color"", ""red"");
        });

        connection.start().then(function () {

            console.log(""Connection is OK!"")

        }).catch(function (err) {
            return console.error(err.toString());
        });


        $("".submit"").click(function () {

            var message = $("".message-input input"").val();
            if ($.trim(message) == '')");
                WriteLiteral(@" {
                return false;
            }

            connection.invoke(""SendMessage"", message).catch(function (err) {
                //return console.error(err.toString());
            });

            //$("".message-input input"").val("""")

        });

        $(window).on('keydown', function (e) {
            if (e.which == 13) {
                $('.submit').trigger('click');
                return false;
            }
        });


        $("".messages"").animate({ scrollTop: $(document).height() }, ""fast"");

        $(""#profile-img"").click(function () {
            $(""#status-options"").toggleClass(""active"");
        });

        $("".expand-button"").click(function () {
            $(""#profile"").toggleClass(""expanded"");
            $(""#contacts"").toggleClass(""expanded"");
        });



        $(""#status-options ul li"").click(function () {
            $(""#profile-img"").removeClass();
            $(""#status-online"").removeClass(""active"");
            $(""#status-away"").removeClass(""active"");
            ");
                WriteLiteral(@"$(""#status-busy"").removeClass(""active"");
            $(""#status-offline"").removeClass(""active"");
            $(this).addClass(""active"");
            if ($(""#status-online"").hasClass(""active"")) {
                $(""#profile-img"").addClass(""online"");
            } else if ($(""#status-away"").hasClass(""active"")) {
                $(""#profile-img"").addClass(""away"");
            } else if ($(""#status-busy"").hasClass(""active"")) {
                $(""#profile-img"").addClass(""busy"");
            } else if ($(""#status-offline"").hasClass(""active"")) {
                $(""#profile-img"").addClass(""offline"");
            } else {
                $(""#profile-img"").removeClass();
            };
            $(""#status-options"").removeClass(""active"");

            var status = $(this).attr('id');


            connection.invoke(""ChangeStatus"", status).catch(function (err) {

            });
            console.log(status);
        });

        connection.on(""UserStatus"", function (userstatus, connectuserid) {
            console.");
                WriteLiteral(@"log(userstatus);
            $(""#"" + connectuserid + "" .contact-status"").removeClass().addClass(""contact-status "" + userstatus);
        })

        //function newMessage() {
        //    message = $("".message-input input"").val();
        //    if ($.trim(message) == '') {
        //        return false;
        //    }
        //    $('<li class=""sent""><img src=""http://emilcarlsson.se/assets/mikeross.png"" alt="""" /><p>' + message + '</p></li>').appendTo($('.messages ul'));
        //    $('.message-input input').val(null);
        //    $('.contact.active .preview').html('<span>You: </span>' + message);
        //    $("".messages"").animate({ scrollTop: $(document).height() }, ""fast"");
        //};

        //$('.submit').click(function () {
        //    newMessage();
        //});

        //$(window).on('keydown', function (e) {
        //    if (e.which == 13) {
        //        $('.submit').trigger('click');
        //        return false;
        //    }
        //});
        //# sourceURL=pen.js
    <");
                WriteLiteral("/script>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n\n\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SignalR.Models.ORM.Entities.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
