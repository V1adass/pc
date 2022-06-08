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
            Description.text=$"Тип памяти: {Videocarta.TypeMemory}\nРазьем подключения {Videocarta.VideoConnectors}"+
            $"\nОбьем видеопамяти {Videocarta.VideoMemory}Gb\nВидеоразьем {Videocarta.СonnectionСonnector}\n Потребление электричества: {Videocarta.Power} Вт";
        }
        else if (ConnecttypeIkon=="Processor")
        {
            Avatar.sprite = Processor.Image;
            Yes.onClick.AddListener(ClotheAndSborka);
            NO.onClick.AddListener(ClothePanelInfo);
            Name.text=Processor.Name;
            Description.text=$"Колво ядер: {Processor.Core}\nКол-во потоков:{Processor.Potoc}"+
            $"\nСокет {Processor.Socket}\nБазовая частота {Processor.Hertz}Ггц \nМаксимальная поддерживаемый объем оперативной памяти {Processor.volumeOperative}\nМаксимально поддерживаемая частота: {Processor.MaxOperHerz}\n Потребление электричества: {Processor.Power} Вт"; 
        }
        else if (ConnecttypeIkon=="Operativka")
        {
            Avatar.sprite = Operativka.Image;
            Yes.onClick.AddListener(ClotheAndSborka);
            NO.onClick.AddListener(ClothePanelInfo);
            Name.text=Operativka.Name;
            Description.text=$"Тип памяти: {Operativka.TypeMemory}\nКол-во модулей:{Operativka.Moduls}"+
            $"\nОбьем памяти {Operativka.ValueMemory}GB\nТактовая частотота {Operativka.Hertz}Ггц\n Форм фактор: {Operativka.FormFactor}\n Потребление электричества: {Operativka.Power}Вт";
        }
        else if (ConnecttypeIkon=="Bp")
        {
            Avatar.sprite = Bp.Image;
            Yes.onClick.AddListener(ClotheAndSborka);
            NO.onClick.AddListener(ClothePanelInfo);
            Name.text=Bp.Name;
            Description.text=$"Формат фактор: {Bp.FormFactor}\nМощность:{Bp.Power} Вт";
        }
        else if (ConnecttypeIkon=="SSD")
        {
            Avatar.sprite = SSD.Image;
            Yes.onClick.AddListener(ClotheAndSborka);
            NO.onClick.AddListener(ClothePanelInfo);
            Name.text=SSD.Name;
            Description.text=$"Формат фактор: {SSD.FormFactor}\nПотребление электричества:{SSD.Power}Вт \nМаксимальная скорость чтения: {SSD.SpeedReed} Мб/Сек \n Тип жеского накопителя: {SSD.TypeSSD}\n Обьем накопителя: {SSD.ValueBp} Гб\n Разьем подключения: {SSD.TypeConnection}" ;
        }
        else if (ConnecttypeIkon=="MatPlat")
        {
            Avatar.sprite = MatPlat.Image;
            Yes.onClick.AddListener(ClotheAndSborka);
            NO.onClick.AddListener(ClothePanelInfo);
            Name.text=MatPlat.Name;
            Description.text=$"Формат фактор: {MatPlat.FormFactor}\nПоддерживаемый сокет {MatPlat.Socket} \nПотребление електричества:{MatPlat.power} Вт\nТип поддерживаемой памяти: {MatPlat.TypeMemory}\nМаксимальный обьем оперативной памяти: {MatPlat.VolueMemory} Gb "+
                 $"\n Версия: {MatPlat.Version}\nВидеоразьем: {MatPlat.VideoConection[0]} {MatPlat.VideoConection[1]} {MatPlat.VideoConection[2]}\n Максимальная частота поддерживаемой памяти: {MatPlat.Hertz} Ггц\n Количество портов m2: {MatPlat.PortM2}\n Количество порто PCI-Ex16: {MatPlat.PortPCIe}"  ;
        }
        else if (ConnecttypeIkon=="Culler")
        {
            Avatar.sprite = Culer.Image;
            Yes.onClick.AddListener(ClotheAndSborka);
            NO.onClick.AddListener(ClothePanelInfo);
            Name.text=Culer.Name;
            Description.text=$"Скорость: {Culer.Speed}\nПотребление электричества:{Culer.Power} Вт\nТип куллера: {Culer.TypeCuller}\n Поддерживаемый сокет: {Culer.Socket[0]} {Culer.Socket[1]} {Culer.Socket[2]} {Culer.Socket[3]} {Culer.Socket[4]}\n Рассеивемая мощность {Culer.TypeCuller} Вт ";
        }
        else if (ConnecttypeIkon=="Corpus")
        {
            Avatar.sprite = Corpus.Image;
            Yes.onClick.AddListener(ClotheAndSborka);
            NO.onClick.AddListener(ClothePanelInfo);
            Name.text=Corpus.Name;
            Description.text=$"Форм фактор: {Corpus.FormFactor}\nДлина:{Corpus.Length}mm\nВысота: {Corpus.Width}mm\nШирина: {Corpus.Height}mm";
        }
        else if (ConnecttypeIkon=="Monitor")
        {
            Avatar.sprite = Monitor.Image;
            Yes.onClick.AddListener(ClotheAndSborka);
            NO.onClick.AddListener(ClothePanelInfo);
            Name.text=Monitor.Name;
            Description.text=$"Диагональ экрана: {Monitor.Size}\nВидео разъемы:{Monitor.VideoConnector[0]} {Monitor.VideoConnector[1]} {Monitor.VideoConnector[2]}\nМаксимальное разрешение: {Monitor.ScreenResolution}\n Технология изготовления матрицы: {Monitor.Matrix}"+
                $"\nЧастота при максимальном разрешении: {Monitor.Frequency}";
        }
        else if (ConnecttypeIkon=="Keyboard")
        {
            Avatar.sprite = Keyboard.Image;
            Yes.onClick.AddListener(ClotheAndSborka);
            NO.onClick.AddListener(ClothePanelInfo);
            Name.text=Keyboard.Name;
            Description.text=$"Тип клавиратуры: {Keyboard.TypeKeyboard}\nОбщее количество клавиш:{Keyboard.Count}\nТип подключения: {Keyboard.TypeKeyboard}\nИнтерфейс подключения: {Keyboard.InterfaceConnector}";
        }
        else if (ConnecttypeIkon=="Mouse")
        {
            Avatar.sprite = Mouse.Image;
            Yes.onClick.AddListener(ClotheAndSborka);
            NO.onClick.AddListener(ClothePanelInfo);
            Name.text=Mouse.Name;
            Description.text=$"Максимальное разрешение датчика: {Mouse.ResolutionOftheSensor}\nОбщее количество кнопок:{Mouse.CountButton}\nТип подключения: {Mouse.TypeConnection}\nИнтерфейс подключения: {Mouse.InterfaceConnection}";
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
