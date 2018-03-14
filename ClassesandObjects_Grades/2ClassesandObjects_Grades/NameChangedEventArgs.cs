// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NameChangedEventArgs.cs" company="">
//   All rights reserved
// </copyright>
// <summary>
//   Defines the NameChangedEventArgs type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace _2ClassesandObjects_Grades
{
  using System;

  /// <summary>
  /// The name changed event args.
  /// </summary>
  public class NameChangedEventArgs : EventArgs
  {
    /// <summary>
    /// Gets or sets the existing name.
    /// </summary>
    public string ExistingName { get; set; }

    /// <summary>
    /// Gets or sets the new name.
    /// </summary>
    public string NewName { get; set; }
  }
}