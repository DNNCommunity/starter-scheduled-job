using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotNetNuke.Instrumentation;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Services.Scheduling;

namespace starter_scheduled_job
{
    /// <summary>
    /// Starter Scheduled Job that can be managed within the DNN scheduler
    /// </summary>
    public class StarterScheduledJob : SchedulerClient
    {
        private static readonly ILog Logger = LoggerSource.Instance.GetLogger(typeof(StarterScheduledJob));

        /// <summary>
        /// Gets things started...
        /// </summary>
        /// <param name="oItem"></param>
        public StarterScheduledJob(ScheduleHistoryItem oItem) : base()
        {
            ScheduleHistoryItem = oItem;
        }

        /// <summary>
        /// This method does all of the real work.
        /// </summary>
        public override void DoWork()
        {
            try
            {
                // Required items for logging
                Progressing();

                ScheduleHistoryItem.AddLogNote("Initiating StarterScheduledJob");

                CustomWork();

                ScheduleHistoryItem.AddLogNote("Completing StarterScheduledJob");

                //Show success
                ScheduleHistoryItem.Succeeded = true;
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                ScheduleHistoryItem.Succeeded = false;
                ScheduleHistoryItem.AddLogNote("Exception: " + ex.ToString());
                Errored(ref ex);
                Exceptions.LogException(ex);
            }
        }

        /// <summary>
        /// Custom work
        /// </summary>
        private void CustomWork()
        {
            try
            {
                //Do custom work
                ScheduleHistoryItem.AddLogNote("This Starter Scheduled Job actually works!");
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                ScheduleHistoryItem.AddLogNote("Exception: " + ex.ToString());
                Exceptions.LogException(ex);
            }
        }
    }
}