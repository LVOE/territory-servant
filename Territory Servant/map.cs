using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using GMap.NET;

namespace Territory_Servant {
  [Serializable]
  public class Map {
    public PointLatLng position;
    public Bitmap bmp, bmp2;
    public bool locked;
    public string name, directions, directions_from, directions_to, notes;
    public Color property_color = Color.FromArgb(237, 230, 220);
    public Color house_color = Color.FromArgb(193, 255, 193);
    public Color dnc_color = Color.FromArgb(255, 73, 73);
    public Color so_color = Color.FromArgb(255, 146, 73);
    public int main_zoom = 17;
    public int area_zoom = 16;

    public List<DNC> dncs;

    public Map() {
      this.locked = false;
      dncs = new List<DNC>();
      name = "";
      directions = "";
      directions_from = "";
      directions_to = "";
    }
  }
}
