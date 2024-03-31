using AdvertisementApp.Common.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvertisementApp.UI.Models
{
    public class AdvertisementUserCreateModel
    {
        public int AdvertisementId { get; set; }
        public int AppUserId { get; set; }
        public int AdvertisementAppUserStatusId { get; set; } = (int)AdvertisementAppUserStatusType.Basvurdu;
        public int MilitaryStatusId { get; set; }
        public DateTime EndDate { get; set; }
        public int WorkExperience { get; set; }
        public IFormFile CvFile { get; set; }
    }
}
