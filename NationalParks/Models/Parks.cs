using System;
using System.Collections.Generic;

namespace NationalParks.Models
{
  // Model for parks data. These classes can be obtained by either using 
  // the Visual Studio editor (right-click -> Paste Special -> Paste Json as Classes)
  // or sites such as JsonToCSHarp
  public class Park
  {
    public string companynumb { get; set; }
    public string receivedate { get; set; }
    }

  public class Parks
  {
    public List<Park> results { get; set; }
  }
}