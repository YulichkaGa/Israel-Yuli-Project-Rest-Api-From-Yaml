/*
 * Arithmetic Operations API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
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
    public partial class OperationRequest
    {
        /// <summary>
        /// Gets or Sets Number1
        /// </summary>

        [Required(ErrorMessage = "Number1 is required.")]
        public double? Number1 { get; set; }

        /// <summary>
        /// Gets or Sets Number2
        /// </summary>

        [Required(ErrorMessage = "Number2 is required.")]
        public double? Number2 { get; set; }
        /// <summary>
        /// Gets or Sets Operation
        /// </summary>
 
    }
}