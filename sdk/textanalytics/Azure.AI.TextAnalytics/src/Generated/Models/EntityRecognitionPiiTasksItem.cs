// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.TextAnalytics
{
    /// <summary> The TasksStateTasksEntityRecognitionPiiTasksItem. </summary>
    public partial class EntityRecognitionPiiTasksItem : TaskState
    {
        /// <summary> Initializes a new instance of EntityRecognitionPiiTasksItem. </summary>
        /// <param name="lastUpdateDateTime"> . </param>
        /// <param name="name"> . </param>
        /// <param name="status"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal EntityRecognitionPiiTasksItem(DateTimeOffset lastUpdateDateTime, string name, JobStatus status) : base(lastUpdateDateTime, name, status)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
        }

        /// <summary> Initializes a new instance of EntityRecognitionPiiTasksItem. </summary>
        /// <param name="lastUpdateDateTime"> . </param>
        /// <param name="name"> . </param>
        /// <param name="status"> . </param>
        /// <param name="results"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal EntityRecognitionPiiTasksItem(DateTimeOffset lastUpdateDateTime, string name, JobStatus status, PiiEntitiesResult results) : base(lastUpdateDateTime, name, status)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Results = results;
        }
    }
}
