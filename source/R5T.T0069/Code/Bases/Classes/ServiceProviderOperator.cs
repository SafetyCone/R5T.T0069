using System;


namespace R5T.T0069
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ServiceProviderOperator : IServiceProviderOperator
    {
        #region Static
        
        public static ServiceProviderOperator Instance { get; } = new();

        #endregion
    }
}