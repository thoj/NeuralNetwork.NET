﻿using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using NeuralNetworkNET.SupervisedLearning.Misc;

namespace NeuralNetworkNET.Networks.PublicAPIs
{
    /// <summary>
    /// A class that contains all the information on a completed training session
    /// </summary>
    public sealed class TrainingSessionResult
    {
        /// <summary>
        /// Gets the result for the training session
        /// </summary>
        public TrainingStopReason StopReason { get; }

        /// <summary>
        /// Gets the number of completed training epochs
        /// </summary>
        public int CompletedEpochs { get; }

        /// <summary>
        /// Gets the approximate training time for the current session
        /// </summary>
        public TimeSpan TrainingTime { get; }

        /// <summary>
        /// Gets the evaluation reports for the validation dataset, if provided
        /// </summary>
        [NotNull]
        public IReadOnlyList<DatasetEvaluationResult> ValidationReports { get; }

        /// <summary>
        /// Gets the evaluation reports for the test set, if provided
        /// </summary>
        [NotNull]
        public IReadOnlyList<DatasetEvaluationResult> TestReports { get; }

        // Internal constructor
        internal TrainingSessionResult(
            TrainingStopReason stopReason, int epochs, TimeSpan time,
            [NotNull] IReadOnlyList<DatasetEvaluationResult> validationReports,
            [NotNull] IReadOnlyList<DatasetEvaluationResult> testReports)
        {
            StopReason = stopReason;
            CompletedEpochs = epochs;
            TrainingTime = time;
            ValidationReports = validationReports;
            TestReports = testReports;
        }
    }
}