namespace NoRealm.Phi.DataEngine.Mapping
{
    /// <summary>
    /// use input context to manually map record to instance of generic type
    /// </summary>
    /// <typeparam name="T">the type name.</typeparam>
    /// <param name="mappingContext">the mapping context.</param>
    /// <returns>optional type instance</returns>
    public delegate T MappingDelegate<out T>(IMappingContext mappingContext) where T : class;
}
