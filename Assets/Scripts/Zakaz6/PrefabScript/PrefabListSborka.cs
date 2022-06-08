using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PrefabListSborka : MonoBehaviour
{
    public Text[] MassivTextComponent;
    public DataVideocarta Videokarta;
    public DataProcessor Processor;
    public DataOperativka Operativka;
    public DataBp Bp;
    public DataSSD SSD;
    public DataMatPlat MatPlat;
    public DataCuller Culler;
    public DataCorpus Corpus;
    public DataMonitor Monitor;
    public DataKeyboard Keyboard;
    public DataMouse Mouse;
    public Button Power;


    public Image PicteVideo;

    public GameObject PanelEror;
    public Text TextPanelEror;

    int Num;
    int Oll;
    private void Start()
    {
        Power.onClick.AddListener(ClickPower);
    }
    private void OnEnable()
    {
        MassivTextComponent[2].text=Videokarta.Name;
        MassivTextComponent[1].text=Processor.Name;
        MassivTextComponent[3].text=Operativka.Name;
        MassivTextComponent[4].text=Bp.Name;
        MassivTextComponent[5].text=SSD.Name;
        MassivTextComponent[0].text= MatPlat.Name;
        MassivTextComponent[6].text=Culler.Name;
        MassivTextComponent[7].text=Corpus.Name;
        MassivTextComponent[8].text=Monitor.Name;
        MassivTextComponent[9].text=Keyboard.Name;
        MassivTextComponent[10].text=Mouse.Name; ;
    }
   
   void ClickPower()
    {

        

        if (MassivTextComponent[1].text=="")
        {
            PanelEror.SetActive(true);
            TextPanelEror.text="�� �� �������� � ������ ���������!";
        }
        else if (MassivTextComponent[2].text=="")
        {
            PanelEror.SetActive(true);
            TextPanelEror.text="�� �� �������� � ������ ����������!";
        }
        else if (MassivTextComponent[3].text=="")
        {
            PanelEror.SetActive(true);
            TextPanelEror.text="�� �� �������� � ������ ����������!";
        }
        else if (MassivTextComponent[4].text=="")
        {
            PanelEror.SetActive(true);
            TextPanelEror.text="�� �� �������� � ������ ���� �������!";
        }
        else if (MassivTextComponent[5].text=="")
        {
            PanelEror.SetActive(true);
            TextPanelEror.text="�� �� �������� � ������ ��������������� ����������!";
        }
        else if (MassivTextComponent[6].text=="")
        {
            PanelEror.SetActive(true);
            TextPanelEror.text="�� �� �������� � ������ ������!";
        }
        else if (MassivTextComponent[0].text=="")
        {
            PanelEror.SetActive(true);
            TextPanelEror.text="�� �� �������� � ������ ����������� �����!";
        }
        else if (MassivTextComponent[7].text=="")
        {
            PanelEror.SetActive(true);
            TextPanelEror.text="�� �� �������� � ������ ������!";
        }
        else if (MassivTextComponent[8].text=="")
        {
            PanelEror.SetActive(true);
            TextPanelEror.text="�� �� �������� � ������ �������!";
        }
        else if (MassivTextComponent[9].text=="")
        {
            PanelEror.SetActive(true);
            TextPanelEror.text="�� �� �������� � ������ ����������!";
        }
        else if (MassivTextComponent[10].text=="")
        {
            PanelEror.SetActive(true);
            TextPanelEror.text="�� �� �������� � ������ ���!";
        }


        else if (�heck()>Bp.Power)
        {
            PanelEror.SetActive(true);
            TextPanelEror.text="�������� ���� ������� ������������� ��������!";
        }
        else if (Processor.Socket!=MatPlat.Socket)
        {
            PanelEror.SetActive(true);
            TextPanelEror.text="������ ������� �� ����������� ����� � ���������� �� ���������!";
        }
        else if (Processor.MaxOperHerz<Operativka.Hertz)
        {
            PanelEror.SetActive(true);
            TextPanelEror.text="������� ���������� ������ ������� ����������� ������!";
        }
        else if (MatPlat.TypeMemory!=Operativka.TypeMemory)
        {
            PanelEror.SetActive(true);
            TextPanelEror.text="������ ����������� ������ �� ������������� ������� ����������� �����.";
        }
        else if (MatPlat.VolueMemory<=Operativka.ValueMemory)
        {
            PanelEror.SetActive(true);
            TextPanelEror.text="�������������� ����� ����������� ������ � ����������� ����� ������, ��� ������������ � ������";
        }
        else if (MatPlat.PortM2>0&&SSD.TypeSSD!="m.2")
        {
            PanelEror.SetActive(true);
            TextPanelEror.text="���������� ���������� ��� ����������� �����.";
        }
        else if (MatPlat.PortM2==0&&SSD.TypeSSD=="m.2")
        {
            PanelEror.SetActive(true);
            TextPanelEror.text="� ����������� ����� ��� ������ ��� ������ ����������.";
        }
        else if (MatPlat.PortSATA==0&&SSD.TypeSSD!="m.2")
        {
            PanelEror.SetActive(true);
            TextPanelEror.text="� ����������� ����� ��� ������ ��� ������ ����������.";
        }
        else if (Monitor.VideoConnector[0]!=MatPlat.VideoConection[0])
        {
            for (int i = 0; i<=MatPlat.VideoConection.Length-1; i++)
            {
                for (int a = 0; a<=Monitor.VideoConnector.Length-1; a++)
                {
                    if (MatPlat.VideoConection[i]!=Monitor.VideoConnector[a])
                    {
                        PanelEror.SetActive(true);
                        TextPanelEror.text=$"������ ����������� ����� {MatPlat.VideoConection[i]} �� ������������� ������� �������� {Monitor.VideoConnector[a]}";
                    }
                    else if (MatPlat.VideoConection[i]==Monitor.VideoConnector[a])
                    {
                        TextPanelEror.gameObject.SetActive(false);
                        SceneManager.LoadScene("Game2222");
                    }
                }


            }
        }
        else if (Culler.Socket[0]!=Processor.Socket)
        {
            for (int i = 0; i<=Culler.Socket.Length-1; i++)
            {
                Debug.Log(1111);
                if (Culler.Socket[i]!=Processor.Socket)
                {
                    PanelEror.SetActive(true);
                    TextPanelEror.text=$"������ ������� {Culler.Socket[i]} �� ������������� ������ ���������� {Processor.Socket}";
                }
                else if (Culler.Socket[i]==Processor.Socket)
                {
                    TextPanelEror.gameObject.SetActive(false);
                    SceneManager.LoadScene("Game2222");
                }
            }
        }

        else
        {
            SceneManager.LoadScene("Game2222");
        }
        
    }

     int �heck()
    {
        Oll=Videokarta.Power+Processor.Power+Operativka.Power+SSD.Power+MatPlat.power+Culler.Power;
        return Oll;
    }
}
