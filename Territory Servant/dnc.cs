using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Territory_Servant {
  [Serializable]
  public class DNC {
    public string house_number, street_address, notes;
    public bool sexual_offender;
    public DateTime date_recorded;
    public Point point; 
  }
}
