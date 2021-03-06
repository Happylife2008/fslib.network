﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace FSLib.Network.Http {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SR {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SR() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FSLib.Network.Http.SR", typeof(SR).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 响应类型无法转换为期望的类型，结果不匹配。是否请求发生了错误导致自动转换，或中途修改了响应类型？ 的本地化字符串。
        /// </summary>
        internal static string HttpContext_CheckResponseType_ResponseTypeMismatch {
            get {
                return ResourceManager.GetString("HttpContext_CheckResponseType_ResponseTypeMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 不可重复调用 {0} 方法 的本地化字符串。
        /// </summary>
        internal static string httpcontext_ex_multiplecall {
            get {
                return ResourceManager.GetString("httpcontext_ex_multiplecall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 已设置禁止301/302跳转，但依然发生了跳转。这可能意味着请求不是预期的响应，请检查。 的本地化字符串。
        /// </summary>
        internal static string httpcontext_ex_redirectiondetected {
            get {
                return ResourceManager.GetString("httpcontext_ex_redirectiondetected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 请求尚未完成，无响应结果 的本地化字符串。
        /// </summary>
        internal static string HttpContext_Result_RequestNotComplete {
            get {
                return ResourceManager.GetString("HttpContext_Result_RequestNotComplete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 WEB请求未能按预期成功完成。 的本地化字符串。
        /// </summary>
        internal static string httpexception_notsucceed {
            get {
                return ResourceManager.GetString("httpexception_notsucceed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 类型 {0} 不支持序列化。请确认返回数据类型支持JSON序列化或二进制序列化，并且服务器返回了正确的数据。 的本地化字符串。
        /// </summary>
        internal static string httpexection_objectserializationnotsupport {
            get {
                return ResourceManager.GetString("httpexection_objectserializationnotsupport", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ContentType 不可为空。 的本地化字符串。
        /// </summary>
        internal static string HttpRequestContent_ContentTypeString_NullOrEmpty {
            get {
                return ResourceManager.GetString("HttpRequestContent_ContentTypeString_NullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 已知的 ContentType 类型必须用属性来设置。 的本地化字符串。
        /// </summary>
        internal static string HttpRequestContent_ContentTypeString_ShouldUseProperty {
            get {
                return ResourceManager.GetString("HttpRequestContent_ContentTypeString_ShouldUseProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 看起来您正在尝试使用内置的对象类来创建 HtmlAgility.HtmlDocument 对象。遗憾的是这个操作并不能正常完成。请使用nuget安装”HtmlAgality Adapter for iFish&apos;s Network Library (HTTP)“包以便于正确支持此类型的返回。 的本地化字符串。
        /// </summary>
        internal static string Tip_HtmlDocumentNotInited {
            get {
                return ResourceManager.GetString("Tip_HtmlDocumentNotInited", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Windows.Forms 下的HtmlDocument不支持反序列化，无法创建。建议使用HtmlAgility中的HtmlDocument代替。请使用nuget安装”HtmlAgality Adapter for iFish&apos;s Network Library (HTTP)“包以便于正确支持此类型的返回。 的本地化字符串。
        /// </summary>
        internal static string Tip_HtmlDocumentNotSupport {
            get {
                return ResourceManager.GetString("Tip_HtmlDocumentNotSupport", resourceCulture);
            }
        }
    }
}
