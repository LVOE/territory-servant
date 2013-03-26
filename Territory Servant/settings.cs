using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Territory_Servant {
  [Serializable]
  public class Settings {
    public string hall_address = "";
    public string cong_name = "";
    public string last_template = "";
    public Color house_color = Color.FromArgb(128, 255, 0);
    public Color dnc_color = Color.FromArgb(255, 255, 0);
    public Color so_color = Color.FromArgb(255, 0, 0);
    public int main_zoom = 17;
    public int area_zoom = 16;
  }
}
