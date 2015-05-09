using System.Runtime.InteropServices;
using ViKey;
public class TiengViet
{
    // Fields
    private string[] amDau = new string[] { 
        "r", "d", "gi", "v", "ch", "tr", "s", "x", "l", "n", "qu", "b", "`c", "/k", "`g", "/gh", 
        "h", "kh", "m", "`ng", "/ngh", "nh", "p", "ph", "t", "th"
     };
    public string[] bangMa;
    public bool boDauKieuMoi;
    public Chu chu;
    private int i;
    public char[] kieuGo;
    private int kq;
    public int ktChinhTa;
    private char mocCu;
    private string[] phuAmCuoi = new string[] { "c", "ch", "m", "n", "ng", "nh", "p", "t" };
    private string s;
    private string[] sacNang = new string[] { "c", "ch", "p", "t" };
    private string stringChinhTa;
    private string value;
    private string[] van = new string[] { 
        "a", "^", "a", "-", "a", "(", "ac", "^", "ac", "-", "ac", "(", "ach", "-", "ai", "-", 
        "ak", "(", "am", "^", "am", "-", "am", "(", "an", "^", "an", "-", "an", "(", "ang", "^", 
        "ang", "-", "ang", "(", "anh", "-", "ao", "-", "ap", "^", "ap", "-", "ap", "(", "at", "^", 
        "at", "-", "at", "(", "au", "^", "au", "-", "ay", "^", "ay", "-", "e", "^", "e", "-", 
        "ec", "-", "ech", "^", "em", "^", "em", "-", "en", "^", "en", "-", "eng", "-", "eng", "^", 
        "enh", "^", "eo", "-", "ep", "^", "ep", "-", "et", "^", "et", "-", "eu", "^", "i", "-", 
        "ia", "-", "ich", "-", "iec", "^", "iem", "^", "ien", "^", "ieng", "^", "iep", "^", "iet", "^", 
        "ieu", "^", "im", "-", "in", "-", "inh", "-", "ip", "-", "it", "-", "iu", "-", "o", "^", 
        "o", "-", "o", "*", "oa", "-", "oac", "-", "oac", "(", "oach", "-", "oai", "-", "oan", "-", 
        "oan", "(", "oang", "-", "oang", "(", "oanh", "-", "oap", "-", "oat", "-", "oat", "-", "oat", "(", 
        "oay", "-", "oc", "^", "oc", "-", "oe", "-", "oeo", "-", "oet", "-", "oi", "^", "oi", "-", 
        "oi", "*", "om", "^", "om", "-", "om", "*", "on", "^", "on", "-", "on", "*", "ong", "^", 
        "ong", "-", "ooc", "-", "op", "^", "op", "-", "op", "*", "ot", "^", "ot", "-", "ot", "*", 
        "u", "-", "u", "*", "ua", "-", "ua", "*", "uan", "^", "uang", "^", "uat", "^", "uay", "^", 
        "uc", "-", "uc", "*", "ue", "^", "uech", "^", "uenh", "^", "ui", "-", "ui", "*", "um", "-", 
        "um", "*", "un", "-", "ung", "-", "ung", "*", "uo", "*", "uoc", "^", "uoc", "*", "uoi", "^", 
        "uoi", "*", "uom", "^", "uom", "*", "uon", "^", "uon", "*", "uong", "^", "uong", "*", "uop", "*", 
        "uot", "^", "uot", "*", "uou", "*", "up", "-", "ut", "-", "ut", "*", "uu", "*", "uy", "-", 
        "uych", "-", "uyen", "^", "uyet", "^", "uynh", "-", "uyp", "-", "uyu", "-", "uyt", "-", "y", "-", 
        "ych", "-", "yem", "^", "yen", "^", "yet", "^", "yeu", "^", "ynh", "-", "yt", "-"
     };
    public bool vanChiIE;
    private DinhNghiaKieuGo viTriDauMoc;

    // Methods
    public TiengViet(string[] ma, char[] go)
    {
        this.bangMa = ma;
        this.kieuGo = go;
        this.chu.Reset();
    }

    public bool ChiSacNang()
    {
        this.stringChinhTa = this.chu.amCuoi.ToLower();
        for (int i = 0; i < this.sacNang.Length; i++)
        {
            if (this.stringChinhTa == this.sacNang[i])
            {
                return true;
            }
        }
        return false;
    }

    private string ChuyenSangTiengViet()
    {
        this.KiemTraViTriDau();
        int num = 0;
        int index = -1;
        string str = "";
        bool flag = false;
        if (this.chu.moc == '^')
        {
            char[] anyOf = new char[] { 'a', 'A' };
            char[] chArray2 = new char[] { 'o', 'O' };
            char[] chArray3 = new char[] { 'e', 'E' };
            char[] chArray4 = new char[] { 'a', 'A', 'o', 'O', 'e', 'E' };
            if ((this.chu.nguyenAm.IndexOfAny(anyOf) < 0) || (this.chu.nguyenAm.IndexOfAny(chArray2) < 0))
            {
                if ((this.chu.nguyenAm.IndexOfAny(chArray2) >= 0) && (this.chu.nguyenAm.IndexOfAny(chArray3) >= 0))
                {
                    return null;
                }
                if ((this.chu.nguyenAm.IndexOfAny(chArray3) >= 0) && (this.chu.nguyenAm.IndexOfAny(anyOf) >= 0))
                {
                    return null;
                }
                if (this.chu.nguyenAm.IndexOfAny(chArray4) < 0)
                {
                    return null;
                }
                for (int j = 0; j < this.chu.nguyenAm.Length; j++)
                {
                    index = -1;
                    if (this.chu.nguyenAm[j] == 'a')
                    {
                        index = 12;
                    }
                    else if (this.chu.nguyenAm[j] == 'A')
                    {
                        index = 0x55;
                    }
                    else if (this.chu.nguyenAm[j] == 'o')
                    {
                        index = 0x2a;
                    }
                    else if (this.chu.nguyenAm[j] == 'O')
                    {
                        index = 0x73;
                    }
                    else if (this.chu.nguyenAm[j] == 'e')
                    {
                        index = 0x18;
                    }
                    else if (this.chu.nguyenAm[j] == 'E')
                    {
                        index = 0x61;
                    }
                    if (index >= 0)
                    {
                        if (this.chu.vitriDau == j)
                        {
                            index += (int)this.chu.dau;
                        }
                        str = str + this.bangMa[index];
                        flag = true;
                    }
                    else
                    {
                        str = str + this.chu.nguyenAm[j];
                    }
                }
                if (flag)
                {
                    return str;
                }
            }
            return null;
        }
        if (this.chu.moc == '*')
        {
            char[] chArray5 = new char[] { 'u', 'o', 'U', 'O' };
            if (this.chu.nguyenAm.IndexOfAny(chArray5) >= 0)
            {
                num = 0;
                for (int k = 0; k < this.chu.nguyenAm.Length; k++)
                {
                    index = -1;
                    if (this.chu.nguyenAm[k] == 'o')
                    {
                        index = 0x30;
                    }
                    else if (this.chu.nguyenAm[k] == 'O')
                    {
                        index = 0x79;
                    }
                    else if (this.chu.nguyenAm[k] == 'u')
                    {
                        if (((this.chu.nguyenAm.ToLower() == "uo") && (this.chu.amCuoi.Length == 0)) && (this.chu.amDau.Length > 0))
                        {
                            index = 0x36;
                        }
                        else
                        {
                            index = 60;
                        }
                        num++;
                    }
                    else if (this.chu.nguyenAm[k] == 'U')
                    {
                        if (((this.chu.nguyenAm.ToLower() == "uo") && (this.chu.amCuoi.Length == 0)) && (this.chu.amDau.Length > 0))
                        {
                            index = 0x7f;
                        }
                        else
                        {
                            index = 0x85;
                        }
                        num++;
                    }
                    if ((index >= 0) && (num < 2))
                    {
                        if (this.chu.vitriDau == k)
                        {
                            index += (int)this.chu.dau;
                        }
                        str = str + this.bangMa[index];
                        flag = true;
                    }
                    else
                    {
                        str = str + this.chu.nguyenAm[k];
                    }
                }
                if (flag)
                {
                    return str;
                }
            }
            return null;
        }
        if (this.chu.moc == '(')
        {
            char[] chArray6 = new char[] { 'a', 'A' };
            if (this.chu.nguyenAm.IndexOfAny(chArray6) >= 0)
            {
                for (int m = 0; m < this.chu.nguyenAm.Length; m++)
                {
                    index = -1;
                    if (this.chu.nguyenAm[m] == 'a')
                    {
                        index = 6;
                    }
                    else if (this.chu.nguyenAm[m] == 'A')
                    {
                        index = 0x4f;
                    }
                    if (index >= 0)
                    {
                        if (this.chu.vitriDau == m)
                        {
                            index += (int)this.chu.dau;
                        }
                        str = str + this.bangMa[index];
                        this.chu.moc = '(';
                        flag = true;
                    }
                    else
                    {
                        str = str + this.chu.nguyenAm[m];
                    }
                }
                if (flag)
                {
                    return str;
                }
            }
            return null;
        }
        for (int i = 0; i < this.chu.nguyenAm.Length; i++)
        {
            index = -1;
            if (this.chu.nguyenAm[i] == 'a')
            {
                index = 0;
            }
            else if (this.chu.nguyenAm[i] == 'A')
            {
                index = 0x49;
            }
            else if (this.chu.nguyenAm[i] == 'o')
            {
                index = 0x24;
            }
            else if (this.chu.nguyenAm[i] == 'O')
            {
                index = 0x6d;
            }
            else if (this.chu.nguyenAm[i] == 'e')
            {
                index = 0x12;
            }
            else if (this.chu.nguyenAm[i] == 'E')
            {
                index = 0x5b;
            }
            else if (this.chu.nguyenAm[i] == 'i')
            {
                index = 30;
            }
            else if (this.chu.nguyenAm[i] == 'I')
            {
                index = 0x67;
            }
            else if (this.chu.nguyenAm[i] == 'u')
            {
                index = 0x36;
            }
            else if (this.chu.nguyenAm[i] == 'U')
            {
                index = 0x7f;
            }
            else if (this.chu.nguyenAm[i] == 'y')
            {
                index = 0x42;
            }
            else if (this.chu.nguyenAm[i] == 'Y')
            {
                index = 0x8b;
            }
            if (index >= 0)
            {
                if (this.chu.vitriDau == i)
                {
                    index += (int)this.chu.dau;
                }
                str = str + this.bangMa[index];
                flag = true;
            }
            else
            {
                str = str + this.chu.nguyenAm[i];
            }
        }
        if (flag)
        {
            return str;
        }
        return null;
    }

    public string Convert(string nguon)
    {
        this.s = this.value = "";
        this.chu.Reset();
        this.i = 0;
        while (this.i < nguon.Length)
        {
            if (this.chu.vitriThanhPhan == 0)
            {
                this.viTriDauMoc = this.TimKiemKieuGo(nguon[this.i]);
                if (this.viTriDauMoc == DinhNghiaKieuGo.DThanhD)
                {
                    if (this.chu.amDau.ToLower() == "d")
                    {
                        this.chu.D9 = true;
                        this.chu.vitriThanhPhan = 1;
                    }
                    else
                    {
                        this.chu.amDau = this.chu.amDau + nguon[this.i];
                    }
                }
                else if (this.viTriDauMoc == DinhNghiaKieuGo.UThanh7OThanh7AThanh8)
                {
                    this.chu.vitriThanhPhan = 1;
                    this.chu.moc = '*';
                    char ch = nguon[this.i];
                    char ch2 = nguon[this.i];
                    if (ch.ToString() == ch2.ToString().ToLower())
                    {
                        this.chu.nguyenAm = "u";
                    }
                    else
                    {
                        this.chu.nguyenAm = "U";
                    }
                    this.chu.UOA = true;
                }
                else if (this.KiemTraNguyenAm(nguon[this.i]))
                {
                    this.chu.vitriThanhPhan = 1;
                    this.chu.nguyenAm = nguon[this.i].ToString();
                }
                else
                {
                    this.chu.amDau = this.chu.amDau + nguon[this.i];
                }
            }
            else if (this.chu.vitriThanhPhan == 1)
            {
                this.viTriDauMoc = this.TimKiemKieuGo(nguon[this.i]);
                if (((this.chu.nguyenAm.Length > 0) && this.KiemTraNguyenAm(nguon[this.i])) || ((this.viTriDauMoc == DinhNghiaKieuGo.UThanh7OThanh7AThanh8) && (this.chu.nguyenAm.Length == 1)))
                {
                    if (((this.chu.amDau == "g") || (this.chu.amDau == "G")) && ((this.chu.nguyenAm[0] == 'i') || (this.chu.nguyenAm[0] == 'I')))
                    {
                        this.chu.amDau = this.chu.amDau + this.chu.nguyenAm[0];
                        this.chu.nguyenAm = this.chu.nguyenAm.Substring(1);
                    }
                    else if (((this.chu.amDau == "q") || (this.chu.amDau == "Q")) && ((this.chu.nguyenAm[0] == 'u') || (this.chu.nguyenAm[0] == 'U')))
                    {
                        this.chu.amDau = this.chu.amDau + this.chu.nguyenAm[0];
                        this.chu.nguyenAm = this.chu.nguyenAm.Substring(1);
                    }
                }
                if ((this.viTriDauMoc == DinhNghiaKieuGo.UThanh7OThanh7AThanh8) && (this.chu.nguyenAm.Length == 0))
                {
                    char ch4 = nguon[this.i];
                    char ch5 = nguon[this.i];
                    if (ch4.ToString() == ch5.ToString().ToLower())
                    {
                        this.chu.nguyenAm = "u";
                    }
                    else
                    {
                        this.chu.nguyenAm = "U";
                    }
                    this.chu.UOA = true;
                }
                if ((this.viTriDauMoc >= DinhNghiaKieuGo.khongDau) && (this.TimKiemAmDau() || (this.ktChinhTa != 2)))
                {
                    if (this.viTriDauMoc == DinhNghiaKieuGo.DThanhD)
                    {
                        if ((this.chu.amDau == "d") || (this.chu.amDau == "D"))
                        {
                            if (this.chu.D9)
                            {
                                this.chu.D9 = false;
                                this.chu.trungdau = this.i;
                                this.chu.vitriThanhPhan = 2;
                                this.chu.amCuoi = nguon[this.i].ToString();
                            }
                            else
                            {
                                this.chu.D9 = true;
                            }
                        }
                        else
                        {
                            this.chu.vitriThanhPhan = 2;
                            this.chu.amCuoi = this.chu.amCuoi + nguon[this.i];
                        }
                    }
                    else if (!this.ThemVaoChu(this.viTriDauMoc, this.i))
                    {
                        if (this.KiemTraNguyenAm(nguon[this.i]))
                        {
                            this.chu.nguyenAm = this.chu.nguyenAm + nguon[this.i];
                        }
                        else
                        {
                            this.chu.vitriThanhPhan = 2;
                            this.chu.amCuoi = this.chu.amCuoi + nguon[this.i];
                        }
                    }
                }
                else if (this.KiemTraNguyenAm(nguon[this.i]))
                {
                    this.chu.nguyenAm = this.chu.nguyenAm + nguon[this.i];
                }
                else
                {
                    this.chu.vitriThanhPhan = 2;
                    this.chu.amCuoi = this.chu.amCuoi + nguon[this.i];
                }
                if (this.chu.trungdau >= 0)
                {
                    this.chu.vitriThanhPhan = 2;
                    this.chu.amCuoi = nguon[this.i].ToString();
                }
            }
            else if (this.chu.vitriThanhPhan == 2)
            {
                this.viTriDauMoc = this.TimKiemKieuGo(nguon[this.i]);
                if (((this.viTriDauMoc >= DinhNghiaKieuGo.khongDau) && (this.TimKiemAmDau() || (this.ktChinhTa == 0))) && (this.TimKiemPhuAmCuoi() && (this.chu.trungdau == -1)))
                {
                    if (this.viTriDauMoc == DinhNghiaKieuGo.DThanhD)
                    {
                        if ((this.chu.amDau == "d") || (this.chu.amDau == "D"))
                        {
                            if (this.chu.D9)
                            {
                                this.chu.D9 = false;
                                this.chu.trungdau = this.i;
                                this.chu.vitriThanhPhan = 2;
                                this.chu.amCuoi = this.chu.amCuoi + nguon[this.i];
                            }
                            else
                            {
                                this.chu.D9 = true;
                            }
                        }
                        else
                        {
                            this.chu.amCuoi = this.chu.amCuoi + nguon[this.i];
                        }
                    }
                    else if (!this.ThemVaoChu(this.viTriDauMoc, this.i) || (this.chu.trungdau >= 0))
                    {
                        this.chu.amCuoi = this.chu.amCuoi + nguon[this.i];
                    }
                }
                else
                {
                    this.chu.amCuoi = this.chu.amCuoi + nguon[this.i];
                }
                if (((this.ktChinhTa != 0) && (this.chu.trungdau < 0)) && ((this.chu.amCuoi.Length > 0) && this.KiemTraNguyenAm(this.chu.amCuoi[this.chu.amCuoi.Length - 1])))
                {
                    return nguon;
                }
            }
            this.i++;
        }
        if (this.chu.D9)
        {
            if (this.chu.amDau != "D")
            {
                if (this.chu.amDau != "d")
                {
                    return nguon;
                }
                this.s = this.bangMa[0x48];
            }
            else
            {
                this.s = this.bangMa[0x91];
            }
        }
        else
        {
            this.s = this.chu.amDau;
        }
        this.value = this.ChuyenSangTiengViet();
        if (this.value != null)
        {
            return (this.s + this.value + this.chu.amCuoi);
        }
        if (this.chu.nguyenAm == "")
        {
            return (this.s + this.chu.amCuoi);
        }
        return nguon;
    }

    public string ConvertNguoc()
    {
        if (((this.chu.vitriDau >= this.chu.nguyenAm.Length) || (this.chu.vitriDau < 0)) || (this.chu.dau == Dau.khongDau))
        {
            this.chu.vitriDau = -1;
            this.chu.dau = Dau.khongDau;
            this.value = this.chu.amDau + this.chu.nguyenAm;
        }
        else
        {
            this.value = this.chu.amDau + this.chu.nguyenAm + this.kieuGo[(int)this.chu.dau];
        }
        if (this.chu.D9 && ((this.chu.amDau == "d") || (this.chu.amDau == "D")))
        {
            this.value = this.value + this.kieuGo[14];
        }
        if (this.chu.moc == '-')
        {
            return (this.value + this.chu.amCuoi);
        }
        if (this.chu.moc == '(')
        {
            if ((this.chu.nguyenAm.IndexOf('a') < 0) && (this.chu.nguyenAm.IndexOf('A') < 0))
            {
                return (this.value + this.chu.amCuoi);
            }
            return (this.value + this.kieuGo[13] + this.chu.amCuoi);
        }
        if (this.chu.moc == '*')
        {
            char[] chArray = "uUoO".ToCharArray();
            if (this.chu.nguyenAm.IndexOfAny(chArray) < 0)
            {
                return (this.value + this.chu.amCuoi);
            }
            if (this.kieuGo[12] != ' ')
            {
                return (this.value + this.kieuGo[12] + this.chu.amCuoi);
            }
            return (this.value + this.kieuGo[10] + this.chu.amCuoi);
        }
        char[] anyOf = "aAoOeE".ToCharArray();
        if (this.chu.nguyenAm.IndexOfAny(anyOf) < 0)
        {
            return (this.value + this.chu.amCuoi);
        }
        if (this.kieuGo[6] != ' ')
        {
            return (this.value + this.kieuGo[6] + this.chu.amCuoi);
        }
        if (this.chu.nguyenAm.IndexOf('a') >= 0)
        {
            return (this.value + this.kieuGo[7] + this.chu.amCuoi);
        }
        if (this.chu.nguyenAm.IndexOf('e') >= 0)
        {
            return (this.value + this.kieuGo[8] + this.chu.amCuoi);
        }
        return (this.value + this.kieuGo[9] + this.chu.amCuoi);
    }

    public bool KiemTraChinhTa()
    {
        string introduced1 = this.chu.nguyenAm.ToLower();
        this.stringChinhTa = introduced1 + this.chu.amCuoi.ToLower();
        if ((this.chu.nguyenAm == "") || ((this.chu.D9 && (this.chu.nguyenAm != "")) && !this.KiemTraNguyenAm(this.chu.nguyenAm[0])))
        {
            return true;
        }
        if ((this.chu.amDau.ToLower() != "gi") || ("iI".IndexOf(this.chu.nguyenAm[0]) < 0))
        {
            if ((this.chu.amDau.ToLower() == "qu") && ("uU".IndexOf(this.chu.nguyenAm[0]) >= 0))
            {
                return false;
            }
            this.kq = -1;
            if ((this.ktChinhTa == 1) && this.TimKiemPhuAmCuoi())
            {
                return true;
            }
            if (this.chu.amDau == "")
            {
                this.kq = 0;
            }
            else if (((this.chu.amDau == "k") || (this.chu.amDau == "K")) && ((this.chu.nguyenAm != "") && ((this.chu.nguyenAm[0] == 'y') || (this.chu.nguyenAm[0] == 'Y'))))
            {
                this.kq = 3;
            }
            else
            {
                this.i = 0;
                while (this.i < this.amDau.Length)
                {
                    if ((this.amDau[this.i][0] == '/') && (this.chu.amDau.ToLower() == this.amDau[this.i].Substring(1).ToLower()))
                    {
                        this.kq = 1;
                        break;
                    }
                    if ((this.amDau[this.i][0] == '`') && (this.chu.amDau.ToLower() == this.amDau[this.i].Substring(1).ToLower()))
                    {
                        this.kq = 2;
                        break;
                    }
                    if (this.chu.amDau.ToLower() == this.amDau[this.i].ToLower())
                    {
                        this.kq = 0;
                        break;
                    }
                    this.i++;
                }
            }
            if (((this.chu.amDau == "g") || (this.chu.amDau == "G")) && ((this.chu.nguyenAm == "i") || (this.chu.nguyenAm == "I")))
            {
                this.kq = 0;
            }
            if ((((this.kq >= 0) && (this.chu.nguyenAm != "")) && ((this.kq != 1) || ("iIeE".IndexOf(this.chu.nguyenAm[0]) >= 0))) && ((this.kq != 2) || ("iIeE".IndexOf(this.chu.nguyenAm[0]) < 0)))
            {
                for (int i = 0; i < this.van.Length; i += 2)
                {
                    if (this.stringChinhTa == this.van[i].ToLower())
                    {
                        if (((this.van[i] == "a") && ((this.chu.moc == '^') || (this.chu.moc == '('))) && ((this.chu.amDau.Length > 0) && (this.chu.amCuoi.Length == 0)))
                        {
                            return false;
                        }
                        if ((this.van[i + 1][0] == this.chu.moc) && ((this.ChiSacNang() && ((this.chu.dau == Dau.sac) || (this.chu.dau == Dau.nang))) || !this.ChiSacNang()))
                        {
                            return true;
                        }
                    }
                }
            }
        }
        return false;
    }

    public bool KiemTraDauMuD()
    {
        if (((this.chu.dau == Dau.khongDau) && (this.chu.moc == '-')) && !this.chu.D9)
        {
            return false;
        }
        return true;
    }

    public bool KiemTraKetThucTu(char c)
    {
        if ((((c < 'A') || ((c > 'Z') && (c < 'a'))) || (c > 'z')) && (this.TimKiemKieuGo(c) == DinhNghiaKieuGo.Null))
        {
            if ((c >= '0') && (c <= '9'))
            {
                return false;
            }
            return true;
        }
        return false;
    }

    public bool KiemTraNguyenAm(char c)
    {
        return ("aAeEiIoOuUyY".IndexOf(c) >= 0);
    }

    private void KiemTraViTriDau()
    {
        if (this.chu.nguyenAm.Length == 1)
        {
            this.chu.vitriDau = 0;
        }
        else if (this.chu.nguyenAm.Length == 2)
        {
            if ((this.chu.nguyenAm[0] == 'a') || (this.chu.nguyenAm[0] == 'A'))
            {
                if (((this.chu.nguyenAm[1] != 'e') && (this.chu.nguyenAm[1] != 'E')) || ((this.chu.nguyenAm[1] != 'a') && (this.chu.nguyenAm[1] != 'A')))
                {
                    this.chu.vitriDau = 0;
                }
                else
                {
                    this.chu.vitriDau = -1;
                }
            }
            else if ((this.chu.nguyenAm[0] == 'e') || (this.chu.nguyenAm[0] == 'E'))
            {
                if ((((this.chu.nguyenAm[1] == 'o') || (this.chu.nguyenAm[1] == 'O')) || ((this.chu.nguyenAm[1] == 'u') || (this.chu.nguyenAm[1] == 'U'))) || ((this.chu.nguyenAm[1] == 'y') || (this.chu.nguyenAm[1] == 'Y')))
                {
                    this.chu.vitriDau = 0;
                }
                else
                {
                    this.chu.vitriDau = -1;
                }
            }
            else if ((this.chu.nguyenAm[0] == 'i') || (this.chu.nguyenAm[0] == 'I'))
            {
                if ((this.chu.nguyenAm[1] == 'e') || (this.chu.nguyenAm[1] == 'E'))
                {
                    this.chu.vitriDau = 1;
                }
                else if (((this.chu.nguyenAm[1] == 'u') || (this.chu.nguyenAm[1] == 'U')) || ((this.chu.nguyenAm[1] == 'a') || (this.chu.nguyenAm[1] == 'A')))
                {
                    this.chu.vitriDau = 0;
                }
                else
                {
                    this.chu.vitriDau = -1;
                }
            }
            else if ((this.chu.nguyenAm[0] == 'o') || (this.chu.nguyenAm[0] == 'O'))
            {
                if (((this.chu.nguyenAm[1] == 'a') || (this.chu.nguyenAm[1] == 'A')) || ((this.chu.nguyenAm[1] == 'e') || (this.chu.nguyenAm[1] == 'E')))
                {
                    if (((this.chu.amCuoi.Length > 0) || this.boDauKieuMoi) || ((this.chu.moc == '^') || (this.chu.moc == '(')))
                    {
                        this.chu.vitriDau = 1;
                    }
                    else
                    {
                        this.chu.vitriDau = 0;
                    }
                }
                else if ((this.chu.nguyenAm[1] == 'i') || (this.chu.nguyenAm[1] == 'I'))
                {
                    this.chu.vitriDau = 0;
                }
                else if ((this.chu.nguyenAm[1] == 'o') || (this.chu.nguyenAm[1] == 'O'))
                {
                    this.chu.vitriDau = 1;
                }
                else
                {
                    this.chu.vitriDau = -1;
                }
            }
            else if ((this.chu.nguyenAm[0] == 'u') || (this.chu.nguyenAm[0] == 'U'))
            {
                if ((this.chu.nguyenAm[1] == 'a') || (this.chu.nguyenAm[1] == 'A'))
                {
                    if (((this.chu.amCuoi.Length > 0) || (this.chu.moc == '^')) || (this.chu.moc == '('))
                    {
                        this.chu.vitriDau = 1;
                    }
                    else
                    {
                        this.chu.vitriDau = 0;
                    }
                }
                else if ((this.chu.nguyenAm[1] == 'e') || (this.chu.nguyenAm[1] == 'E'))
                {
                    this.chu.vitriDau = 1;
                }
                else if (((this.chu.nguyenAm[1] == 'i') || (this.chu.nguyenAm[1] == 'I')) || ((this.chu.nguyenAm[1] == 'u') || (this.chu.nguyenAm[1] == 'U')))
                {
                    this.chu.vitriDau = 0;
                }
                else if ((this.chu.nguyenAm[1] == 'y') || (this.chu.nguyenAm[1] == 'Y'))
                {
                    if ((this.chu.amCuoi.Length > 0) || this.boDauKieuMoi)
                    {
                        this.chu.vitriDau = 1;
                    }
                    else
                    {
                        this.chu.vitriDau = 0;
                    }
                }
                else if ((this.chu.nguyenAm[1] == 'o') || (this.chu.nguyenAm[1] == 'O'))
                {
                    this.chu.vitriDau = 1;
                }
                else
                {
                    this.chu.vitriDau = -1;
                }
            }
            else if ((this.chu.nguyenAm[0] == 'y') || (this.chu.nguyenAm[0] == 'Y'))
            {
                this.chu.vitriDau = 1;
            }
            else
            {
                this.chu.vitriDau = -1;
            }
        }
        else if (this.chu.nguyenAm.Length == 3)
        {
            switch (this.chu.nguyenAm.Substring(0, 3).ToLower())
            {
                case "uye":
                    this.chu.vitriDau = 2;
                    return;

                case "uou":
                case "ieu":
                case "oai":
                case "uay":
                case "oay":
                case "uoi":
                case "uya":
                case "yeu":
                case "oeo":
                case "uyu":
                    this.chu.vitriDau = 1;
                    return;
            }
            this.chu.vitriDau = -1;
        }
        else
        {
            this.chu.vitriDau = -1;
        }
    }

    public void Reset()
    {
        this.chu.Reset();
    }

    private bool ThemVaoChu(DinhNghiaKieuGo dnkg, int trungDau)
    {
        if ((dnkg >= DinhNghiaKieuGo.khongDau) && (dnkg <= DinhNghiaKieuGo.nang))
        {
            this.KiemTraViTriDau();
            if ((this.chu.vitriDau == -1) || (this.chu.nguyenAm.Length == 0))
            {
                return false;
            }
            if (this.chu.dau == ((Dau)((int)dnkg)))
            {
                if (this.chu.dau == Dau.khongDau)
                {
                    return false;
                }
                this.chu.trungdau = trungDau;
                this.chu.dau = Dau.khongDau;
                this.chu.vitriThanhPhan = 2;
            }
            if (this.chu.trungdau == -1)
            {
                this.chu.dau = (Dau)dnkg;
            }
            return true;
        }
        this.mocCu = this.chu.moc;
        if (dnkg == DinhNghiaKieuGo.DauMuChungAOE)
        {
            char[] anyOf = new char[] { 'a', 'A', 'o', 'O', 'e', 'E' };
            if (this.chu.nguyenAm.IndexOfAny(anyOf) < 0)
            {
                return false;
            }
            this.chu.moc = '^';
        }
        else if (dnkg == DinhNghiaKieuGo.AThanh6)
        {
            char[] chArray2 = new char[] { 'a', 'A' };
            char[] chArray3 = new char[] { 'o', 'O', 'e', 'E' };
            if ((this.chu.nguyenAm.IndexOfAny(chArray2) < 0) || (this.chu.nguyenAm.IndexOfAny(chArray3) >= 0))
            {
                return false;
            }
            this.chu.moc = '^';
        }
        else if (dnkg == DinhNghiaKieuGo.EThanh6)
        {
            char[] chArray4 = new char[] { 'E', 'e' };
            char[] chArray5 = new char[] { 'a', 'A', 'o', 'O' };
            if ((this.chu.nguyenAm.IndexOfAny(chArray4) < 0) || (this.chu.nguyenAm.IndexOfAny(chArray5) >= 0))
            {
                return false;
            }
            this.chu.moc = '^';
        }
        else if (dnkg == DinhNghiaKieuGo.OThanh6)
        {
            char[] chArray6 = new char[] { 'O', 'o' };
            char[] chArray7 = new char[] { 'a', 'A', 'e', 'E' };
            if ((this.chu.nguyenAm.IndexOfAny(chArray6) < 0) || (this.chu.nguyenAm.IndexOfAny(chArray7) >= 0))
            {
                return false;
            }
            this.chu.moc = '^';
        }
        else if ((dnkg == DinhNghiaKieuGo.UThanh7OThanh7AThanh8) || (dnkg == DinhNghiaKieuGo.UOASimple))
        {
            char[] chArray8 = new char[] { 'a', 'A' };
            if (((((this.chu.nguyenAm.Length == 0) || (this.chu.nguyenAm[0] == 'u')) || (this.chu.nguyenAm[0] == 'U')) || ((this.chu.nguyenAm.IndexOfAny(chArray8) < 0) && (this.chu.nguyenAm[0] == 'o'))) || (this.chu.nguyenAm[0] == 'O'))
            {
                char[] chArray9 = new char[] { 'u', 'o', 'U', 'O' };
                if (this.chu.nguyenAm.IndexOfAny(chArray9) < 0)
                {
                    return false;
                }
                if (this.chu.nguyenAm.Length == 1)
                {
                    this.chu.UODau = true;
                }
                this.chu.moc = '*';
            }
            else
            {
                if (this.chu.nguyenAm.IndexOfAny(chArray8) < 0)
                {
                    return false;
                }
                this.chu.moc = '(';
            }
        }
        else if (dnkg == DinhNghiaKieuGo.UThanh7OThanh7)
        {
            char[] chArray10 = new char[] { 'u', 'o', 'U', 'O' };
            if (this.chu.nguyenAm.IndexOfAny(chArray10) < 0)
            {
                return false;
            }
            if (this.chu.nguyenAm.Length == 1)
            {
                this.chu.UODau = true;
            }
            this.chu.moc = '*';
        }
        else if (dnkg == DinhNghiaKieuGo.AThanh8)
        {
            char[] chArray11 = new char[] { 'a', 'A' };
            if (this.chu.nguyenAm.IndexOfAny(chArray11) < 0)
            {
                return false;
            }
            this.chu.moc = '(';
        }
        if (((this.chu.moc == '*') && (this.mocCu == '*')) && (this.chu.UODau && (this.chu.nguyenAm.Length == 2)))
        {
            this.mocCu = '-';
            this.chu.UODau = false;
        }
        if (this.chu.moc == this.mocCu)
        {
            this.chu.trungdau = trungDau;
            this.chu.moc = '-';
            this.chu.vitriThanhPhan = 2;
            if ((this.mocCu == '*') && (dnkg == DinhNghiaKieuGo.UThanh7OThanh7AThanh8))
            {
                if (this.chu.nguyenAm[0] == 'U')
                {
                    this.chu.amCuoi = this.chu.amCuoi + this.kieuGo[10].ToString().ToUpper();
                }
                else
                {
                    this.chu.amCuoi = this.chu.amCuoi + this.kieuGo[10].ToString().ToLower();
                }
                if (this.chu.UOA)
                {
                    this.chu.nguyenAm = this.chu.nguyenAm.Substring(1);
                }
            }
        }
        return true;
    }

    public bool TimKiemAmDau()
    {
        if (((this.chu.amDau.ToLower() == "gi") && (this.chu.nguyenAm.Length > 0)) && ("iI".IndexOf(this.chu.nguyenAm[0]) >= 0))
        {
            return false;
        }
        if (((this.chu.amDau.ToLower() == "qu") && (this.chu.nguyenAm.Length > 0)) && ("uU".IndexOf(this.chu.nguyenAm[0]) >= 0))
        {
            return false;
        }
        this.kq = -1;
        if (this.chu.amDau == "")
        {
            this.kq = 0;
        }
        else if (((this.chu.amDau == "k") || (this.chu.amDau == "K")) && ((this.chu.nguyenAm != "") && ((this.chu.nguyenAm[0] == 'y') || (this.chu.nguyenAm[0] == 'Y'))))
        {
            this.kq = 3;
        }
        else
        {
            for (int i = 0; i < this.amDau.Length; i++)
            {
                if ((this.amDau[i][0] == '/') && (this.chu.amDau.ToLower() == this.amDau[i].Substring(1).ToLower()))
                {
                    this.kq = 1;
                    break;
                }
                if ((this.amDau[i][0] == '`') && (this.chu.amDau.ToLower() == this.amDau[i].Substring(1).ToLower()))
                {
                    this.kq = 2;
                    break;
                }
                if (this.chu.amDau.ToLower() == this.amDau[i].ToLower())
                {
                    this.kq = 0;
                    break;
                }
            }
        }
        if (((this.chu.amDau == "g") || (this.chu.amDau == "G")) && ((this.chu.nguyenAm == "i") || (this.chu.nguyenAm == "I")))
        {
            this.kq = 0;
        }
        return ((((this.kq >= 0) && (this.chu.nguyenAm != "")) && ((this.kq != 1) || ("iIeE".IndexOf(this.chu.nguyenAm[0]) >= 0))) && ((this.kq != 2) || ("iIeE".IndexOf(this.chu.nguyenAm[0]) < 0)));
    }

    public DinhNghiaKieuGo TimKiemKieuGo(char tim)
    {
        for (int i = 0; i < this.kieuGo.Length; i++)
        {
            if ((this.kieuGo[i] != ' ') && (this.kieuGo[i].ToString().ToLower() == tim.ToString().ToLower()))
            {
                return (DinhNghiaKieuGo)i;
            }
        }
        return DinhNghiaKieuGo.Null;
    }

    public bool TimKiemPhuAmCuoi()
    {
        if (this.chu.amCuoi == "")
        {
            return true;
        }
        this.stringChinhTa = this.chu.amCuoi.ToLower();
        for (int i = 0; i < this.phuAmCuoi.Length; i++)
        {
            if (this.stringChinhTa == this.phuAmCuoi[i])
            {
                return true;
            }
        }
        return ((this.stringChinhTa == "k") || ((this.ktChinhTa != 2) && ((this.stringChinhTa == "h") || (this.stringChinhTa == "k"))));
    }

    // Nested Types
    [StructLayout(LayoutKind.Sequential)]
    public struct Chu
    {
        public bool D9;
        public bool UODau;
        public bool UOA;
        public string amDau;
        public string nguyenAm;
        public string amCuoi;
        public int vitriDau;
        public int vitriThanhPhan;
        public int trungdau;
        public TiengViet.Dau dau;
        public char moc;
        public void Reset()
        {
            this.vitriThanhPhan = 0;
            this.D9 = this.UODau = this.UOA = false;
            this.amDau = this.nguyenAm = this.amCuoi = "";
            this.dau = TiengViet.Dau.khongDau;
            this.moc = '-';
            this.vitriDau = this.trungdau = -1;
        }
    }

    public enum Dau
    {
        khongDau,
        sac,
        huyen,
        nga,
        hoi,
        nang
    }
}





