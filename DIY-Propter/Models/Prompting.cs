using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DIY_Propter.Models
{
    public class Prompting
    {
        [BsonId]
        public Guid PromptID { get; set; }

        public string Title { get; set; }
        public string Text { get; set; }

    }
}