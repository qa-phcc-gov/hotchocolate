﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotChocolate.Authorization.Properties {
    using System;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class AuthCoreResources {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AuthCoreResources() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("HotChocolate.Authorization.Properties.AuthCoreResources", typeof(AuthCoreResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        internal static string AuthorizeMiddleware_NoDefaultPolicy {
            get {
                return ResourceManager.GetString("AuthorizeMiddleware_NoDefaultPolicy", resourceCulture);
            }
        }
        
        internal static string AuthorizeMiddleware_NotAuthorized {
            get {
                return ResourceManager.GetString("AuthorizeMiddleware_NotAuthorized", resourceCulture);
            }
        }
        
        internal static string AuthorizeMiddleware_PolicyNotFound {
            get {
                return ResourceManager.GetString("AuthorizeMiddleware_PolicyNotFound", resourceCulture);
            }
        }
        
        internal static string AuthorizeMiddleware_PoliciesMissing {
            get {
                return ResourceManager.GetString("AuthorizeMiddleware_PoliciesMissing", resourceCulture);
            }
        }
        
        internal static string ThrowHelper_StateNotInitialized {
            get {
                return ResourceManager.GetString("ThrowHelper_StateNotInitialized", resourceCulture);
            }
        }
        
        internal static string ThrowHelper_UnauthorizedType {
            get {
                return ResourceManager.GetString("ThrowHelper_UnauthorizedType", resourceCulture);
            }
        }
        
        internal static string ThrowHelper_UnableToResolveTypeReg {
            get {
                return ResourceManager.GetString("ThrowHelper_UnableToResolveTypeReg", resourceCulture);
            }
        }
    }
}
