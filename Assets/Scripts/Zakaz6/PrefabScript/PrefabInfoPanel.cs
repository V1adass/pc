using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefabInfoPanel : MonoBehaviour
{
    public PrefabListSborka ScriptSborka;

    public DataVideocarta Videocarta;
    public DataProcessor Processor;
    public DataOperativka Operativka;
    public DataBp Bp;
    public DataSSD SSD;
    public Text Name;
    public Text Description;
    public Image Avatar;
    public Button NO;
    public Button Yes;
    public string ConnecttypeIkon;
    public DataMatPlat MatPlat;
    public DataCuller Culer;
    public DataCorpus Corpus;
    public DataMonitor Monitor;
    public DataKeyboard Keyboard;
    public DataMouse Mouse;
    
     void OnEnable()
    {
        if (ConnecttypeIkon=="Videocarta")
        {
            Avatar.sprite = Videocarta.Image;
            Yes.onClick.AddListener(ClotheAndSborka);
            NO.onClick.AddListener(ClothePanelInfo);
            Name.text=Videocarta.Name;
            Description.text=$"��� ������: {Videocarta.TypeMemory}\n������ ����������� {Videocarta.VideoConnectors}"+
            $"\n����� ����������� {Videocarta.VideoMemory}Gb\n����������� {Videocarta.�onnection�onnector}\n ����������� �������������: {Videocarta.Power} ��";
        }
        else if (ConnecttypeIkon=="Processor")
        {
            Avatar.sprite = Processor.Image;
            Yes.onClick.AddListener(ClotheAndSborka);
            NO.onClick.AddListener(ClothePanelInfo);
            Name.text=Processor.Name;
            Description.text=$"����� ����: {Processor.Core}\n���-�� �������:{Processor.Potoc}"+
            $"\n����� {Processor.Socket}\n������� ������� {Processor.Hertz}��� \n������������ �������������� ����� ����������� ������ {Processor.volumeOperative}\n����������� �������������� �������: {Processor.MaxOperHerz}\n ����������� �������������: {Processor.Power} ��"; 
        }
        else if (ConnecttypeIkon=="Operativka")
        {
            Avatar.sprite = Operativka.Image;
            Yes.onClick.AddListener(ClotheAndSborka);
            NO.onClick.AddListener(ClothePanelInfo);
            Name.text=Operativka.Name;
            Description.text=$"��� ������: {Operativka.TypeMemory}\n���-�� �������:{Operativka.Moduls}"+
            $"\n����� ������ {Operativka.ValueMemory}GB\n�������� ��������� {Operativka.Hertz}���\n ���� ������: {Operativka.FormFactor}\n ����������� �������������: {Operativka.Power}��";
        }
        else if (ConnecttypeIkon=="Bp")
        {
            Avatar.sprite = Bp.Image;
            Yes.onClick.AddListener(ClotheAndSborka);
            NO.onClick.AddListener(ClothePanelInfo);
            Name.text=Bp.Name;
            Description.text=$"������ ������: {Bp.FormFactor}\n��������:{Bp.Power} ��";
        }
        else if (ConnecttypeIkon=="SSD")
        {
            Avatar.sprite = SSD.Image;
            Yes.onClick.AddListener(ClotheAndSborka);
            NO.onClick.AddListener(ClothePanelInfo);
            Name.text=SSD.Name;
            Description.text=$"������ ������: {SSD.FormFactor}\n����������� �������������:{SSD.Power}�� \n������������ �������� ������: {SSD.SpeedReed} ��/��� \n ��� ������� ����������: {SSD.TypeSSD}\n ����� ����������: {SSD.ValueBp} ��\n ������ �����������: {SSD.TypeConnection}" ;
        }
        else if (ConnecttypeIkon=="MatPlat")
        {
            Avatar.sprite = MatPlat.Image;
            Yes.onClick.AddListener(ClotheAndSborka);
            NO.onClick.AddListener(ClothePanelInfo);
            Name.text=MatPlat.Name;
            Description.text=$"������ ������: {MatPlat.FormFactor}\n�������������� ����� {MatPlat.Socket} \n����������� �������������:{MatPlat.power} ��\n��� �������������� ������: {MatPlat.TypeMemory}\n������������ ����� ����������� ������: {MatPlat.VolueMemory} Gb "+
                 $"\n ������: {MatPlat.Version}\n�����������: {MatPlat.VideoConection[0]} {MatPlat.VideoConection[1]} {MatPlat.VideoConection[2]}\n ������������ ������� �������������� ������: {MatPlat.Hertz} ���\n ���������� ������ m2: {MatPlat.PortM2}\n ���������� ����� PCI-Ex16: {MatPlat.PortPCIe}"  ;
        }
        else if (ConnecttypeIkon=="Culler")
        {
            Avatar.sprite = Culer.Image;
            Yes.onClick.AddListener(ClotheAndSborka);
            NO.onClick.AddListener(ClothePanelInfo);
            Name.text=Culer.Name;
            Description.text=$"��������: {Culer.Speed}\n����������� �������������:{Culer.Power} ��\n��� �������: {Culer.TypeCuller}\n �������������� �����: {Culer.Socket[0]} {Culer.Socket[1]} {Culer.Socket[2]} {Culer.Socket[3]} {Culer.Socket[4]}\n ����������� �������� {Culer.TypeCuller} �� ";
        }
        else if (ConnecttypeIkon=="Corpus")
        {
            Avatar.sprite = Corpus.Image;
            Yes.onClick.AddListener(ClotheAndSborka);
            NO.onClick.AddListener(ClothePanelInfo);
            Name.text=Corpus.Name;
            Description.text=$"���� ������: {Corpus.FormFactor}\n�����:{Corpus.Length}mm\n������: {Corpus.Width}mm\n������: {Corpus.Height}mm";
        }
        else if (ConnecttypeIkon=="Monitor")
        {
            Avatar.sprite = Monitor.Image;
            Yes.onClick.AddListener(ClotheAndSborka);
            NO.onClick.AddListener(ClothePanelInfo);
            Name.text=Monitor.Name;
            Description.text=$"��������� ������: {Monitor.Size}\n����� �������:{Monitor.VideoConnector[0]} {Monitor.VideoConnector[1]} {Monitor.VideoConnector[2]}\n������������ ����������: {Monitor.ScreenResolution}\n ���������� ������������ �������: {Monitor.Matrix}"+
                $"\n������� ��� ������������ ����������: {Monitor.Frequency}";
        }
        else if (ConnecttypeIkon=="Keyboard")
        {
            Avatar.sprite = Keyboard.Image;
            Yes.onClick.AddListener(ClotheAndSborka);
            NO.onClick.AddListener(ClothePanelInfo);
            Name.text=Keyboard.Name;
            Description.text=$"��� �����������: {Keyboard.TypeKeyboard}\n����� ���������� ������:{Keyboard.Count}\n��� �����������: {Keyboard.TypeKeyboard}\n��������� �����������: {Keyboard.InterfaceConnector}";
        }
        else if (ConnecttypeIkon=="Mouse")
        {
            Avatar.sprite = Mouse.Image;
            Yes.onClick.AddListener(ClotheAndSborka);
            NO.onClick.AddListener(ClothePanelInfo);
            Name.text=Mouse.Name;
            Description.text=$"������������ ���������� �������: {Mouse.ResolutionOftheSensor}\n����� ���������� ������:{Mouse.CountButton}\n��� �����������: {Mouse.TypeConnection}\n��������� �����������: {Mouse.InterfaceConnection}";
        }

    }

  void ClothePanelInfo()
    {
        gameObject.SetActive(false);
    }
    void ClotheAndSborka()
    {
        if (ConnecttypeIkon=="Videocarta")
        {
            ScriptSborka.Videokarta= Videocarta;
            gameObject.SetActive(false);
        }else if (ConnecttypeIkon=="Processor")
        {
            ScriptSborka.Processor= Processor;
            gameObject.SetActive(false);
        }
        else if (ConnecttypeIkon=="Operativka")
        {
            ScriptSborka.Operativka= Operativka;
            gameObject.SetActive(false);
        }
        else if (ConnecttypeIkon=="Bp")
        {
            ScriptSborka.Bp= Bp;
            gameObject.SetActive(false);
        }
        else if (ConnecttypeIkon=="SSD")
        {
            ScriptSborka.SSD= SSD;
            gameObject.SetActive(false);
        }
        else if (ConnecttypeIkon=="MatPlat")
        {
            ScriptSborka.MatPlat= MatPlat;
            gameObject.SetActive(false);
        }
        else if (ConnecttypeIkon=="Culler")
        {
            ScriptSborka.Culler= Culer;
            gameObject.SetActive(false);
        }
        else if (ConnecttypeIkon=="Corpus")
        {
            ScriptSborka.Corpus= Corpus;
            gameObject.SetActive(false);
        }
        else if (ConnecttypeIkon=="Monitor")
        {
            ScriptSborka.Monitor= Monitor;
            gameObject.SetActive(false);
        }
        else if (ConnecttypeIkon=="Keyboard")
        {
            ScriptSborka.Keyboard= Keyboard;
            gameObject.SetActive(false);
        }
        else if (ConnecttypeIkon=="Mouse")
        {
            ScriptSborka.Mouse= Mouse;
            gameObject.SetActive(false);
        }

    }
}
