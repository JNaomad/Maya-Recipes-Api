/*
 * API de recettes
 *
 * Une API pour créer, lire, mettre à jour et supprimer des recettes.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Recipe : IEquatable<Recipe>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>

        [DataMember(Name="id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>

        [DataMember(Name="title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets ImageURL
        /// </summary>

        [DataMember(Name="imageURL")]
        public string ImageURL { get; set; }

        /// <summary>
        /// Gets or Sets Ingredients
        /// </summary>

        [DataMember(Name="ingredients")]
        public List<string> Ingredients { get; set; }

        /// <summary>
        /// Gets or Sets Ustensils
        /// </summary>

        [DataMember(Name="ustensils")]
        public List<string> Ustensils { get; set; }

        /// <summary>
        /// Gets or Sets Steps
        /// </summary>

        [DataMember(Name="steps")]
        public List<Step> Steps { get; set; }

        /// <summary>
        /// Gets or Sets PreparationTime
        /// </summary>

        [DataMember(Name="preparationTime")]
        public int? PreparationTime { get; set; }

        /// <summary>
        /// Gets or Sets CookingTime
        /// </summary>

        [DataMember(Name="cookingTime")]
        public int? CookingTime { get; set; }

        /// <summary>
        /// Gets or Sets PriceLevel
        /// </summary>

        [DataMember(Name="priceLevel")]
        public int? PriceLevel { get; set; }

        /// <summary>
        /// Gets or Sets QuickDescription
        /// </summary>

        [DataMember(Name="quickDescription")]
        public string QuickDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Recipe {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  ImageURL: ").Append(ImageURL).Append("\n");
            sb.Append("  Ingredients: ").Append(Ingredients).Append("\n");
            sb.Append("  Ustensils: ").Append(Ustensils).Append("\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
            sb.Append("  PreparationTime: ").Append(PreparationTime).Append("\n");
            sb.Append("  CookingTime: ").Append(CookingTime).Append("\n");
            sb.Append("  PriceLevel: ").Append(PriceLevel).Append("\n");
            sb.Append("  QuickDescription: ").Append(QuickDescription).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Recipe)obj);
        }

        /// <summary>
        /// Returns true if Recipe instances are equal
        /// </summary>
        /// <param name="other">Instance of Recipe to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Recipe other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Title == other.Title ||
                    Title != null &&
                    Title.Equals(other.Title)
                ) && 
                (
                    ImageURL == other.ImageURL ||
                    ImageURL != null &&
                    ImageURL.Equals(other.ImageURL)
                ) && 
                (
                    Ingredients == other.Ingredients ||
                    Ingredients != null &&
                    Ingredients.SequenceEqual(other.Ingredients)
                ) && 
                (
                    Ustensils == other.Ustensils ||
                    Ustensils != null &&
                    Ustensils.SequenceEqual(other.Ustensils)
                ) && 
                (
                    Steps == other.Steps ||
                    Steps != null &&
                    Steps.SequenceEqual(other.Steps)
                ) && 
                (
                    PreparationTime == other.PreparationTime ||
                    PreparationTime != null &&
                    PreparationTime.Equals(other.PreparationTime)
                ) && 
                (
                    CookingTime == other.CookingTime ||
                    CookingTime != null &&
                    CookingTime.Equals(other.CookingTime)
                ) && 
                (
                    PriceLevel == other.PriceLevel ||
                    PriceLevel != null &&
                    PriceLevel.Equals(other.PriceLevel)
                ) && 
                (
                    QuickDescription == other.QuickDescription ||
                    QuickDescription != null &&
                    QuickDescription.Equals(other.QuickDescription)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();
                    if (ImageURL != null)
                    hashCode = hashCode * 59 + ImageURL.GetHashCode();
                    if (Ingredients != null)
                    hashCode = hashCode * 59 + Ingredients.GetHashCode();
                    if (Ustensils != null)
                    hashCode = hashCode * 59 + Ustensils.GetHashCode();
                    if (Steps != null)
                    hashCode = hashCode * 59 + Steps.GetHashCode();
                    if (PreparationTime != null)
                    hashCode = hashCode * 59 + PreparationTime.GetHashCode();
                    if (CookingTime != null)
                    hashCode = hashCode * 59 + CookingTime.GetHashCode();
                    if (PriceLevel != null)
                    hashCode = hashCode * 59 + PriceLevel.GetHashCode();
                    if (QuickDescription != null)
                    hashCode = hashCode * 59 + QuickDescription.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Recipe left, Recipe right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Recipe left, Recipe right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
