//-----------------------------------------------------------------------
// <copyright file="PublishingProfileModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Publishing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Vasont.Inspire.Models.Components;
    using Vasont.Inspire.Models.Security;
    using Vasont.Inspire.Models.Transfers;

    /// <summary>
    /// Contains an enumerated list of publishing profile status.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PublishingProfileStatus
    {
        /// <summary>
        /// The publishing profile has been queued.
        /// </summary>
        Pending,

        /// <summary>
        /// The publishing profile has been submitted to the publish server.
        /// </summary>
        Submitted,

        /// <summary>
        /// The publishing profile job has completed successfully.
        /// </summary>
        Success,

        /// <summary>
        /// The publishing profile job has failed.
        /// </summary>
        Failed
    }

    /// <summary>
    /// Contains an enumerated list of scheduled publishing types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ScheduledPublishingType
    {
        /// <summary>
        /// Scheduled publishing will occur every day.
        /// </summary>
        EveryDay,

        /// <summary>
        /// Scheduled publishing will occur every work day.
        /// </summary>
        EveryWorkDay,

        /// <summary>
        /// Scheduled publishing will occur every specified day of the week.
        /// </summary>
        DayOfTheWeek,

        /// <summary>
        /// Scheduled publishing will occur every day of the month.
        /// </summary>
        DayOfTheMonth
    }

    /// <summary>
    /// Contains an enumerated list of week day names.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ScheduledDay
    {
        /// <summary>
        /// None.
        /// </summary>
        None,

        /// <summary>
        /// Monday.
        /// </summary>
        Monday,

        /// <summary>
        /// Tuesday.
        /// </summary>
        Tuesday,

        /// <summary>
        /// Wednesday.
        /// </summary>
        Wednesday,

        /// <summary>
        /// Thursday.
        /// </summary>
        Thursday,

        /// <summary>
        /// Friday.
        /// </summary>
        Friday,

        /// <summary>
        /// Saturday.
        /// </summary>
        Saturday,

        /// <summary>
        /// Sunday.
        /// </summary>
        Sunday
    }

    /// <summary>
    /// This model class represents the profile detail for a publishing profile.
    /// </summary>
    public class PublishingProfileModel
    {
        /// <summary>
        /// Gets or sets the profile identity.
        /// </summary>
        public long ProfileId { get; set; }

        /// <summary>
        /// Gets or sets the profile name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the profile.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the component identity.
        /// </summary>
        public List<long> ComponentIds { get; set; } = new List<long>();

        /// <summary>
        /// Gets or sets the component information about the component associated with the publishing profile.
        /// </summary>
        public List<MicroComponentModel> Components { get; set; } = new List<MicroComponentModel>();

        /// <summary>
        /// Gets or sets a value indicating whether the profile should be validated.
        /// </summary>
        public bool SkipXmlValidation { get; set; } = false;

        /// <summary>
        /// Gets or sets the filter condition for the profile.
        /// </summary>
        public string Filter { get; set; }

        /// <summary>
        /// Gets or sets a value indicating with the export config id.
        /// </summary>
        public long ExportId { get; set; }

        /// <summary>
        /// Gets or sets the export configuration associated with the publishing profile.
        /// </summary>
        public MinimalExportModel ExportConfig { get; set; } = new MinimalExportModel();

        /// <summary>
        /// Gets or sets a value indicating whether the publishing profile is archived.
        /// </summary>
        public bool Archived { get; set; }

        /// <summary>
        /// Gets or sets the publishing profile archival date time.
        /// </summary>
        public DateTime? ArchivedDate { get; set; }

        /// <summary>
        /// Gets or sets the date time when the profile was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the user information about the user who last updated the profile.
        /// </summary>
        public MinimalUserModel CreatedBy { get; set; } = new MinimalUserModel();

        /// <summary>
        /// Gets or sets the date time when the profile was last updated.
        /// </summary>
        public DateTime UpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets the user information about the user who last updated the profile.
        /// </summary>
        public MinimalUserModel UpdatedBy { get; set; } = new MinimalUserModel();

        /// <summary>
        /// Gets or sets the date time when the profile was last published.
        /// </summary>
        public DateTime? LastPublishedDate { get; set; }

        /// <summary>
        /// Gets or sets the user information about the user who last published the profile.
        /// </summary>
        public MinimalUserModel LastPublishedBy { get; set; } = new MinimalUserModel();

        /// <summary>
        /// Gets or sets the last published status of the profile.
        /// </summary>
        public PublishingProfileStatus? Status { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether scheduled publish is enabled.
        /// </summary>
        public bool ScheduledPublishing { get; set; }

        /// <summary>
        /// Gets or sets the scheduled publishing type.
        /// </summary>
        public ScheduledPublishingType? ScheduledPublishingType { get; set; }

        /// <summary>
        /// <summary>
        /// Gets or sets time of day to publish.
        /// </summary>
        public DateTime? ScheduledTime { get; set; }

        /// <summary>
        /// <summary>
        /// Gets or sets the week day to publish.
        /// </summary>
        public ScheduledDay? ScheduledDayOfWeek { get; set; }

        /// <summary>
        /// Gets or sets the day of the month to publish.
        /// </summary>
        public int? ScheduledDayOfMonth { get; set; } // 1 - 30
    }
}
