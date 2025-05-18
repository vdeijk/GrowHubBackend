namespace Models
{
    public class MongoDbSettings
    {
        public string ConnectionString { get; set; } = string.Empty;
        public string DatabaseName { get; set; } = string.Empty;
        public string CropsCollectionName { get; set; } = string.Empty;
        public string BatchesCollectionName { get; set; } = string.Empty;
        public string ReadingsCollectionName { get; set; } = string.Empty;
        public string TodosCollectionName { get; set; } = string.Empty;
        public string FieldsCollectionName { get; set; } = string.Empty;
    }
}