﻿namespace MyWebApi.Builders.Contracts.BadRequests
{
    using Base;

    /// <summary>
    /// Used for testing specific bad request error messages.
    /// </summary>
    public interface IBadRequestErrorMessageTestBuilder : IBaseTestBuilder
    {
        /// <summary>
        /// Tests whether particular error message is equal to given message.
        /// </summary>
        /// <param name="errorMessage">Expected error message for particular key.</param>
        /// <returns>Base test builder.</returns>
        IBaseTestBuilder ThatEquals(string errorMessage);

        /// <summary>
        /// Tests whether particular error message begins with given message.
        /// </summary>
        /// <param name="beginMessage">Expected beginning for particular error message.</param>
        /// <returns>Base test builder.</returns>
        IBaseTestBuilder BeginningWith(string beginMessage);

        /// <summary>
        /// Tests whether particular error message ends with given message.
        /// </summary>
        /// <param name="endMessage">Expected ending for particular error message.</param>
        /// <returns>Base test builder.</returns>
        IBaseTestBuilder EndingWith(string endMessage);

        /// <summary>
        /// Tests whether particular error message contains given message.
        /// </summary>
        /// <param name="containsMessage">Expected containing string for particular error message.</param>
        /// <returns>Base test builder.</returns>
        IBaseTestBuilder Containing(string containsMessage);
    }
}