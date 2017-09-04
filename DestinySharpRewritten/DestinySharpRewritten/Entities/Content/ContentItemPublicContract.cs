
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Content
{
    public class ContentItemPublicContract
    {
        public int contentId;
        public string cType;
        public string cmsPath;
        public string creationDate;
        public string modifyDate;
        public bool allowComments;
        public bool hasAgeGate;
        public int minimumAge;
        public string ratingImagePath;
        public User.GeneralUser author;
        public bool autoEnglishPropertyFallback;
        public Content.ContentRepresentation[] representations;
        public string[] tags;
        public Content.CommentSummary commentSummary;
    }
}