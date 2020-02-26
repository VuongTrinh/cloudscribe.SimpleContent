﻿

using cloudscribe.MetaWeblog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cloudscribe.MetaWeblog
{
    public class MetaWeblogRequest
    {
        public MetaWeblogRequest()
        {

        }

        /// <summary>
        ///     Gets AppKey is a key generated by the calling application.  It is sent with blogger API calls.
        /// </summary>
        /// <remarks>
        ///     BlogEngine.NET doesn't require specific AppKeys for API calls.  It is no longer standard practive.
        /// </remarks>
        public string AppKey { get; set; }

        /// <summary>
        ///     Gets ID of the Blog to call the function on.  Since BlogEngine supports only a single blog instance,
        ///     this incoming parameter is not used.
        /// </summary>
        public string BlogId { get; set; }

        /// <summary>
        ///     Gets MediaObject is a struct sent by the metaWeblog.newMediaObject function.
        ///     It contains information about the media and the object in a bit array.
        /// </summary>
        public MediaObjectStruct MediaObject { get; set; }

        /// <summary>
        ///     Gets Name of Called Metaweblog Function
        /// </summary>
        public string MethodName { get; set; }

        /// <summary>
        ///     Gets Number of post request by the metaWeblog.getRecentPosts function
        /// </summary>
        public int NumberOfPosts { get; set; }

        /// <summary>
        ///     Gets Metaweblog Page Struct
        /// </summary>
        public PageStruct Page { get; set; }

        /// <summary>
        ///     Gets PageID Guid in string format
        /// </summary>
        public string PageId { get; set; }

        /// <summary>
        ///     Gets Password for user validation
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        ///    Gets Metaweblog Post struct containing information post including title, content, and categories.
        /// </summary>
        public PostStruct Post { get; set; }

        /// <summary>
        ///     Gets The PostID Guid in string format
        /// </summary>
        public string PostId { get; set; }

        /// <summary>
        ///     Gets a value indicating whether or not a post will be marked as published by BlogEngine.
        /// </summary>
        public bool Publish { get; set; }

        /// <summary>
        ///     Gets Login for user validation
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        ///     Gets Category for wp.newCategory
        /// </summary>
        public string Category { get; set; }

    }
}