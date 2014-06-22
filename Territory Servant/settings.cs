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
    public Color boundary_color = Color.FromArgb(200, 206, 229);
    public Color house_color = Color.FromArgb(133, 243, 67);
    public Color dnc_color = Color.FromArgb(247, 247, 73);
    public Color so_color = Color.FromArgb(255, 57, 57);
    public int main_zoom = 17;
    public int area_zoom = 16;
  }
}
