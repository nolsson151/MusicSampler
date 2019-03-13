using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicSampler.Models
{
    public class Sample
    {
        /// <summary>
        /// Sample ID
        /// </summary>
        [Key]
        public string SampleID { get; set; }

        /// <summary>
        /// Title of the sample
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Name of the sample artist
        /// </summary>
        public string Artist { get; set; }

        /// <summary>
        /// URL of the sample blob
        /// </summary>
        public string SampleBlobURL { get; set; }
    }
}