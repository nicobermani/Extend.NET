using System.Xml.Serialization;

namespace Extend.NET.Dictionary
{
    public static partial class DictionaryExtensions
    {
        /// <summary>
        /// Converts the dictionary to a serializable dictionary.
        /// </summary>
        /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
        /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
        /// <param name="dictionary">The dictionary to convert.</param>
        /// <returns>A new SerializableDictionary containing all key-value pairs from the original dictionary.</returns>
        public static SerializableDictionary<TKey, TValue> ToSerializableDictionary<TKey, TValue>(
            this IDictionary<TKey, TValue> dictionary)
        {
            return new SerializableDictionary<TKey, TValue>(dictionary);
        }
    }

    [Serializable]
    public class SerializableDictionary<TKey, TValue> : Dictionary<TKey, TValue>, IXmlSerializable
    {
        public SerializableDictionary() { }

        public SerializableDictionary(IDictionary<TKey, TValue> dictionary) : base(dictionary) { }

        public System.Xml.Schema.XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(System.Xml.XmlReader reader)
        {
            var keySerializer = new System.Xml.Serialization.XmlSerializer(typeof(TKey));
            var valueSerializer = new System.Xml.Serialization.XmlSerializer(typeof(TValue));

            bool wasEmpty = reader.IsEmptyElement;
            reader.Read();

            if (wasEmpty)
                return;

            while (reader.NodeType != System.Xml.XmlNodeType.EndElement)
            {
                reader.ReadStartElement("item");

                reader.ReadStartElement("key");
                TKey key = (TKey)keySerializer.Deserialize(reader);
                reader.ReadEndElement();

                reader.ReadStartElement("value");
                TValue value = (TValue)valueSerializer.Deserialize(reader);
                reader.ReadEndElement();

                this.Add(key, value);

                reader.ReadEndElement();
                reader.MoveToContent();
            }
            reader.ReadEndElement();
        }

        public void WriteXml(System.Xml.XmlWriter writer)
        {
            var keySerializer = new System.Xml.Serialization.XmlSerializer(typeof(TKey));
            var valueSerializer = new System.Xml.Serialization.XmlSerializer(typeof(TValue));

            foreach (TKey key in this.Keys)
            {
                writer.WriteStartElement("item");

                writer.WriteStartElement("key");
                keySerializer.Serialize(writer, key);
                writer.WriteEndElement();

                writer.WriteStartElement("value");
                TValue value = this[key];
                valueSerializer.Serialize(writer, value);
                writer.WriteEndElement();

                writer.WriteEndElement();
            }
        }
    }
}