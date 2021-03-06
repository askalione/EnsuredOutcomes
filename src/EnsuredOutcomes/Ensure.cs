﻿// Copyright (c) Paul Bentley 2019. All rights reserved.
// Licensed under the MIT license. See the LICENSE file in the project root for full license information.

namespace EnsuredOutcomes
{
    using System;

    /// <summary>
    /// Ensures against invalid parameter input.
    /// </summary>
    public static class Ensure
    {
        /// <summary>
        /// Throws an exception if <paramref name="value"/> is null.
        /// </summary>
        /// <param name="value">The value to test.</param>
        /// <param name="parameterName">The name of the parameter.</param>
        public static void NotNull([ValidatedNotNull]object value, string parameterName) =>
            Exceptions.ThrowWhenNull(value, parameterName);

        /// <summary>
        /// Throws an exception if <paramref name="value"/> is null or empty.
        /// </summary>
        /// <param name="value">The value to test.</param>
        /// <param name="parameterName">The name of the parameter.</param>
        public static void NotNullOrEmpty([ValidatedNotNull]string value, string parameterName) =>
            Exceptions.ThrowWhenNullOrEmpty(value, parameterName);

        /// <summary>
        /// Throws an exception if <paramref name="value"/> is null or whitespace.
        /// </summary>
        /// <param name="value">The value to test.</param>
        /// <param name="parameterName">The name of the parameter.</param>
        public static void NotNullOrWhitespace([ValidatedNotNull]string value, string parameterName) =>
            Exceptions.Throw(Exceptions.WhenNullOrWhiteSpace(value, parameterName));

        /// <summary>
        /// Throws an exception if the length  of <paramref name="value"/> is outside a minimum and maximum.
        /// </summary>
        /// <param name="value">The value to test.</param>
        /// <param name="minimumLength">The minimum length.</param>
        /// <param name="maximumLength">The maximum length.</param>
        /// <param name="parameterName">The name of the parameter.</param>
        public static void LengthBetween([ValidatedNotNull]string value, int minimumLength, int maximumLength, string parameterName) =>
            Exceptions.Throw(Exceptions.WhenLengthIsIncorrect(value, minimumLength, maximumLength, parameterName));

        /// <summary>
        /// Throws an exception if <paramref name="value"/> does not match the <paramref name="pattern"/>.
        /// </summary>
        /// <param name="value">The value to test.</param>
        /// <param name="pattern">The pattern.</param>
        /// <param name="parameterName">The name of the parameter.</param>
        public static void MatchesPattern([ValidatedNotNull]string value, string pattern, string parameterName) =>
            Exceptions.Throw(Exceptions.WhenDoesNotMatchPattern(value, pattern, parameterName));

        /// <summary>
        /// Throws an exception if <paramref name="value"/> is less than the given minimum value.
        /// </summary>
        /// <param name="value">The value to test.</param>
        /// <param name="minValue">The minimum value.</param>
        /// <param name="parameterName">The name of the parameter.</param>
        public static void InRange(DateTime value, DateTime minValue, string parameterName) =>
            Exceptions.Throw(Exceptions.WhenOutOfRange(value, minValue, parameterName));
    }
}
