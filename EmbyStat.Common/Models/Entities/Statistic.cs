﻿using System;
using System.Collections.Generic;
using EmbyStat.Common.Enums;
using LiteDB;

namespace EmbyStat.Common.Models.Entities
{
    public class Statistic
    {
        [BsonId]
        public Guid Id { get; set; }
        public DateTime CalculationDateTime { get; set; }
        public StatisticType Type { get; set; }
        public string JsonResult { get; set; }
        public IEnumerable<string> CollectionIds { get; set; }
        public bool IsValid { get; set; }
    }
}
