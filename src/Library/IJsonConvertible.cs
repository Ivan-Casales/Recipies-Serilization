
namespace Recipies
{
    public interface IJsonConvertible
    {
        /// <summary>
        /// Convirte el objeto a texto en formato Json. El objeto puede ser reconstruido a partir del texto en formato
        /// Json utilizando <see cref="LoadFromJson"/>.
        /// </summary>
        /// <returns>El objeto convertido a texto en formato Json.</returns>
        string ConvertToJson();
        /// <summary>
        /// Asigna las propiedades del objeto a partir de texto en formato Json. El texto en formato Json puede ser
        /// obtenido utilizando <see cref="ConvertToJson"/>.
        /// </summary>
        /// <param name="json">El texto en formato Json a partir del cual asignas las propiedades del objeto.</param>
        void LoadFromJson(string json);
    }
}