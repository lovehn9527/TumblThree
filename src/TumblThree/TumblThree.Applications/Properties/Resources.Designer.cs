﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TumblThree.Applications.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TumblThree.Applications.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The blog already exist:  {0}.
        /// </summary>
        public static string BlogAlreadyExist {
            get {
                return ResourceManager.GetString("BlogAlreadyExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Blog is Offline: {0}.
        /// </summary>
        public static string BlogIsOffline {
            get {
                return ResourceManager.GetString("BlogIsOffline", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not add the blog:  {0}.
        /// </summary>
        public static string CouldNotAddBlog {
            get {
                return ResourceManager.GetString("CouldNotAddBlog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not load file in library: {0}.
        /// </summary>
        public static string CouldNotLoadLibrary {
            get {
                return ResourceManager.GetString("CouldNotLoadLibrary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The queuelist could not be loaded. Maybe some referenced blogs do not exist anymore..
        /// </summary>
        public static string CouldNotLoadQueuelist {
            get {
                return ResourceManager.GetString("CouldNotLoadQueuelist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A file could not be opened..
        /// </summary>
        public static string CouldNotOpenFiles {
            get {
                return ResourceManager.GetString("CouldNotOpenFiles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not remove the blog: {0}.
        /// </summary>
        public static string CouldNotRemoveBlog {
            get {
                return ResourceManager.GetString("CouldNotRemoveBlog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not remove the blog: {0}.
        /// </summary>
        public static string CouldNotRemoveBlogIndex {
            get {
                return ResourceManager.GetString("CouldNotRemoveBlogIndex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not save the blog: {0}.
        /// </summary>
        public static string CouldNotSaveBlog {
            get {
                return ResourceManager.GetString("CouldNotSaveBlog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The queuelist could not be saved..
        /// </summary>
        public static string CouldNotSaveQueueList {
            get {
                return ResourceManager.GetString("CouldNotSaveQueueList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Crawler Thread encountered an error..
        /// </summary>
        public static string CrawlerError {
            get {
                return ResourceManager.GetString("CrawlerError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Downloading {0}..
        /// </summary>
        public static string ProgressDownloadImage {
            get {
                return ResourceManager.GetString("ProgressDownloadImage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Evaluated {0} tumblr post urls out of {1} total posts..
        /// </summary>
        public static string ProgressGetUrl {
            get {
                return ResourceManager.GetString("ProgressGetUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Queuelist.
        /// </summary>
        public static string Queuelist {
            get {
                return ResourceManager.GetString("Queuelist", resourceCulture);
            }
        }
    }
}
