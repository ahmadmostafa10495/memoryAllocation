using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryAllocation
{
   
    public partial class MemoryAllocation : Form
    {
        List<Process> myHoles = new List<Process>();
        List<Process> myProcesses = new List<Process>();
        List<Process> myMemory = new List<Process>();
        int FFFB = 0,BFFB=0;
        int numberOfProcesses = 0, numberOFHoles = 0, TempNOP = 0;

        public MemoryAllocation()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ScreeningTextBox.Multiline = true;
            ScreeningTextBox.ScrollBars = ScrollBars.Vertical;
            ScreeningTextBox.WordWrap = true;      
            FirstFitRadioButton.Checked = true;
            CompactionModeONRadio.Checked = true;
            NumberOfProcessesGroupBox.Enabled = false;
            ProcessesGroupBox.Enabled = false;
            MethodOfAllocationGroupBox.Enabled = false;
            DeAllocationGroupBox.Enabled = false;
            AllocationGroupBox.Enabled = false;
            CompactionGroupBox.Enabled = false;
        }
        private void AddHole_Click(object sender, EventArgs e)
        {
            myHoles.Add(new Process(int.Parse(HoleSizeTextBox.Text), "hole", int.Parse(HoleAddressTextBox.Text)));
            myMemory.Add(new Process(int.Parse(HoleSizeTextBox.Text), "hole", int.Parse(HoleAddressTextBox.Text)));
            NumberOfHolesLabel.Text= (++numberOFHoles).ToString();
            HoleSizeTextBox.Clear();
            HoleAddressTextBox.Clear();
        }
        public void fillMem()
        {
            sortByAddress();
            if (myMemory[0].getAddress() != 0)
            {
                myMemory.Add(new Process(myMemory[0].getAddress(), "Unknown", 0));
            }
            int x = myMemory.Count();
            for(int i=0; i < x - 1; i++)
            {
                if ((myMemory[i].getSize() + myMemory[i].getAddress()) < myMemory[i + 1].getAddress()){
                    myMemory.Add(new Process((myMemory[i + 1].getAddress())- (myMemory[i].getSize() + myMemory[i].getAddress())
                                              , "Unknown", (myMemory[i].getSize() + myMemory[i].getAddress())));
                }
            }
            sortByAddress();
        }
        private void HoleFinish_Click(object sender, EventArgs e)
        {
            fillMem();
            sortByAddress();
            CompactionGroupBox.Enabled = true;
            HolesGroupBox.Enabled = false;
        }
        private void CompactionModeButton_Click(object sender, EventArgs e)
        {
            CompactionGroupBox.Enabled = false;
            NumberOfProcessesGroupBox.Enabled = true;
            if (CompactionModeONRadio.Checked == true)
            {
                CompactionModeLabel.Text = "Compaction ON";               
            }
            else
            {
                CompactionModeLabel.Text = "Compaction OFF";
            }
        }

        private void NumberOfProcessesFinish_Click(object sender, EventArgs e)
        {
            numberOfProcesses= int.Parse(NumberOfProcessesTextBox.Text);
            TempNOP = numberOfProcesses;
            ProcessesGroupBox.Enabled = true;
            NumberOfProcessesGroupBox.Enabled = false;
            HolesGroupBox.Enabled = false;
        }

        private void AddProcessButton_Click(object sender, EventArgs e)
        {
            
            if (TempNOP > 0)
            {
                myProcesses.Add(new Process(int.Parse(ProcessSizeTextBox.Text), ProcessNameTextBox.Text, 000));                
                ProcessSizeTextBox.Clear();
                ProcessNameTextBox.Clear();
                TempNOP--;
            }
            if(TempNOP == 0)
            {
                MethodOfAllocationGroupBox.Enabled = true;
                ProcessesGroupBox.Enabled = false;
                NumberOfProcessesGroupBox.Enabled = false;
                HolesGroupBox.Enabled = false;
                toBePrinted("initial state");
                ProcessestoBePrinted("Processes initial state");
            }

        }

         private void MethodOfAllocationButton_Click(object sender, EventArgs e)
        {
            if (FirstFitRadioButton.Checked == true)
            {
                FirsttFit();
                Test.Text = "First Fit";
                
            }
            else
            {
                BestFit();
                Test.Text = "Best Fit";
            }
            DeAllocationGroupBox.Enabled = true;
            AllocationGroupBox.Enabled = true;
            MethodOfAllocationGroupBox.Enabled = false;
            ProcessesGroupBox.Enabled = false;
            NumberOfProcessesGroupBox.Enabled = false;
            HolesGroupBox.Enabled = false;
        }

        public void BestFit() {
            for(int i = 0; i < numberOfProcesses; i++)
            {
                sortBySize();
                int j = 0;
                for (j = 0; j < myMemory.Count(); j++)
                {
                    if ((myMemory[j].getName() == "hole")&&(myMemory[j].getSize()>=myProcesses[i].getSize()))
                    {
                        myMemory[j].setName(myProcesses[i].getName());
                        int tempSize = myMemory[j].getSize();
                        myMemory[j].setSize(myProcesses[i].getSize());
                        if ((tempSize - myProcesses[i].getSize()) > 0)
                        {
                            myMemory.Add(new Process((tempSize - myProcesses[i].getSize()),
                                                  "hole",
                                                   (myMemory[j].getAddress() + myProcesses[i].getSize())));
                        }
                        break;

                    }
                    
                }
                sortByAddress();
                if (j < myMemory.Count())
                {

                    string s = "After " + myProcesses[i].getName() + " allocation";
                    toBePrinted(s);
                }
                else if(CompactionModeONRadio.Checked==true)
                {                   
                    compact(myProcesses[i].getSize());
                    if ((myMemory[myMemory.Count()-1].getSize()>=myProcesses[i].getSize())&&(myMemory[myMemory.Count() - 1].getName()=="hole"))
                    {
                        myMemory[myMemory.Count()-1].setName(myProcesses[i].getName());
                        int tempSize = myMemory[myMemory.Count() - 1].getSize();
                        myMemory[myMemory.Count() - 1].setSize(myProcesses[i].getSize());
                        if ((tempSize - myProcesses[i].getSize()) > 0)
                        {
                            myMemory.Add(new Process((tempSize - myProcesses[i].getSize()),
                                                  "hole",
                                                   (myMemory[myMemory.Count() - 1].getAddress() + myProcesses[i].getSize())));
                        }
                        string s = "After " + myProcesses[i].getName() + " allocation with compaction";
                        toBePrinted(s);
                    }
                    else
                    {
                        string s = myProcesses[i].getName() + " could not be allocated..even after compaction"; 
                        toBePrinted(s);
                    }                   

                }

                else if(CompactionModeOFFRadio.Checked ==true)
                {
                    string s = myProcesses[i].getName() + " could not be allocated..you can deallocate other process and try again";
                    toBePrinted(s);
                }
            }
        }
        public void FirsttFit() {
            for(int i = 0; i < numberOfProcesses; i++)
            {
                FFFB = 0;
                int x = myMemory.Count();
                int j = 0;
                for (j = 0; j < x; j++)
                {
                    if ((myMemory[j].getName() == "hole") && (myMemory[j].getSize() >= myProcesses[i].getSize())&&(FFFB==0))
                    {
                        myMemory[j].setName(myProcesses[i].getName());
                        int tempSize = myMemory[j].getSize();
                        myMemory[j].setSize(myProcesses[i].getSize());
                        if((tempSize - myProcesses[i].getSize()) > 0)
                        {
                            myMemory.Add(new Process((tempSize - myProcesses[i].getSize()), 
                                                  "hole", 
                                                   (myMemory[j].getAddress() + myProcesses[i].getSize())));
                           

                        }                        
                        sortByAddress();
                        FFFB = 1;

                    }                    
                }
                if (j < myMemory.Count())
                {
                    string s = "After " + myProcesses[i].getName() + " allocation";
                    toBePrinted(s);
                }
                else if (CompactionModeONRadio.Checked == true)
                {
                    compact(myProcesses[i].getSize());
                    if ((myMemory[myMemory.Count() - 1].getSize() >= myProcesses[i].getSize()) && (myMemory[myMemory.Count() - 1].getName() == "hole"))
                    {
                        myMemory[myMemory.Count() - 1].setName(myProcesses[i].getName());
                        int tempSize = myMemory[myMemory.Count() - 1].getSize();
                        myMemory[myMemory.Count() - 1].setSize(myProcesses[i].getSize());
                        if ((tempSize - myProcesses[i].getSize()) > 0)
                        {
                            myMemory.Add(new Process((tempSize - myProcesses[i].getSize()),
                                                  "hole",
                                                   (myMemory[myMemory.Count() - 1].getAddress() + myProcesses[i].getSize())));
                        }
                        string s = "After " + myProcesses[i].getName() + " allocation with compaction";
                        toBePrinted(s);
                    }
                    else
                    {
                        string s = myProcesses[i].getName() + " could not be allocated..even after compaction";
                        toBePrinted(s);
                    }

                }

                else if (CompactionModeOFFRadio.Checked == true)
                {
                    string s = myProcesses[i].getName() + " could not be allocated..you can deallocate other process and try again";
                     toBePrinted(s);
                }
            }
        }
        public void sortByAddress()
        {
            for (int j = 0; j < myMemory.Count(); j++) {
                for (int i = 0; i < myMemory.Count() - 1; i++) {
                    if (myMemory[i].getAddress() > myMemory[i + 1].getAddress()) {
                        Process temp = myMemory[i];
                        myMemory[i] = myMemory[i + 1];
                        myMemory[i + 1] = temp;
                    }
                }
            }
        }
        public void sortBySize()
        {
            for (int j = 0; j < myMemory.Count(); j++)
            {
                for (int i = 0; i < myMemory.Count() - 1; i++)
                {
                    if (myMemory[i].getSize() > myMemory[i + 1].getSize())
                    {
                        Process temp = myMemory[i];
                        myMemory[i] = myMemory[i + 1];
                        myMemory[i + 1] = temp;
                    }
                }
            }


        }

        public void toBePrinted(string state)
        {
            ScreeningTextBox.Text += state +="\r\n";
            for(int i = 0; i < myMemory.Count(); i++)
            {
                ScreeningTextBox.Text +="Address "+ myMemory[i].getAddress()+"    "+ myMemory[i].getName() +"   Size "+myMemory[i].getSize()+ "   Finishes at Address "+ (myMemory[i].getAddress()+myMemory[i].getSize()) + "\r\n";
            }
            ScreeningTextBox.Text += "\r\n*********************************************\r\n";


        }
        public void ProcessestoBePrinted(string state)
        {
            ScreeningTextBox.Text += state += "\r\n";
            for (int i = 0; i < myProcesses.Count(); i++)
            {
                ScreeningTextBox.Text += myProcesses[i].getName() + "   Size " + myProcesses[i].getSize() + "\r\n";
            }
            ScreeningTextBox.Text += "\r\n*********************************************\r\n";


        }
        public void DeAllocate(string name)
        {
            int index=100000000;
            for (int i = 0; i < myMemory.Count(); i++)
            {
                if (myMemory[i].getName().Equals(name))
                {
                    index = i;
                    break;
                }
            }
            myMemory[index].setName("hole");
            if (index>0)
            {
                if ((myMemory[index - 1].getName() == "hole") && ((myMemory[index - 1].getAddress() + myMemory[index - 1].getSize()) == myMemory[index].getAddress()))
                {
                    cascade(index - 1, index);
                    index--;
                }

            }
            if (index <(myMemory.Count()-1))
            {
                if ((myMemory[index + 1].getName() == "hole") && ((myMemory[index].getAddress() + myMemory[index].getSize()) == myMemory[index + 1].getAddress()))
                {
                    cascade(index, index + 1);
                    index--;
                }
            }
                
            string s = "After " + name + " is de-allocated";
            toBePrinted(s);

        }
        public void cascade(int FirstIndex,int SecondIndex)
        {
            myMemory[FirstIndex].setName("hole");
            myMemory[FirstIndex].setSize((myMemory[FirstIndex].getSize()) + (myMemory[SecondIndex].getSize()));
            myMemory[FirstIndex].setAddress(myMemory[FirstIndex].getAddress());
            myMemory.RemoveAt(SecondIndex);

        }
        private void DeAllocationButton_Click(object sender, EventArgs e)
        {
            DeAllocate(ProcessToBeAllocatedNameTextBox.Text);
            ProcessToBeAllocatedNameTextBox.Clear();
        }
        private void AllocationButton_Click(object sender, EventArgs e)
        {
            Allocate(ProcessNameAllocationTextBox.Text, int.Parse(ProcessSizeAllocationTextBox.Text));
            ProcessSizeAllocationTextBox.Clear();
            ProcessNameAllocationTextBox.Clear();
        }
        public void Allocate(string pName, int pSize)
        {
            Process p = new Process(pSize, pName, 0);
            if(BestFitRadioButton.Checked==true)
            {
                sortBySize();
                int j = 0;
                for (j = 0; j < myMemory.Count(); j++)
                {
                    if ((myMemory[j].getName() == "hole") && (myMemory[j].getSize() >= p.getSize()))
                    {
                        myMemory[j].setName(p.getName());
                        int tempSize = myMemory[j].getSize();
                        myMemory[j].setSize(p.getSize());
                        if ((tempSize - p.getSize()) > 0)
                        {
                            myMemory.Add(new Process((tempSize - p.getSize()),
                                                  "hole",
                                                   (myMemory[j].getAddress() + p.getSize())));
                        }
                        break;

                    }
                }
                sortByAddress();
                if (j < myMemory.Count())
                {
                    string s = "After " + p.getName() + " allocation";
                    toBePrinted(s);
                }
                else if (CompactionModeONRadio.Checked == true)
                {
                    compact(p.getSize());
                    if ((myMemory[myMemory.Count() - 1].getSize() >= p.getSize()) && (myMemory[myMemory.Count() - 1].getName() == "hole"))
                    {
                        myMemory[myMemory.Count() - 1].setName(p.getName());
                        int tempSize = myMemory[myMemory.Count() - 1].getSize();
                        myMemory[myMemory.Count() - 1].setSize(p.getSize());
                        if ((tempSize - p.getSize()) > 0)
                        {
                            myMemory.Add(new Process((tempSize - p.getSize()),
                                                  "hole",
                                                   (myMemory[myMemory.Count() - 1].getAddress() + p.getSize())));
                        }
                        string s = "After " + p.getName() + " allocation with compaction";
                        toBePrinted(s);
                    }
                    else
                    {
                        string s = p.getName() + " could not be allocated..even after compaction";
                        toBePrinted(s);
                    }

                }

                else if (CompactionModeOFFRadio.Checked == true)
                {
                    string s = p.getName() + " could not be allocated..you can deallocate other process and try again";
                    toBePrinted(s);
                }


            }
            else if(FirstFitRadioButton.Checked==true)
            {
                Process p1 = new Process(pSize, pName, 0);
                int j = 0;
                for (j = 0; j < myMemory.Count; j++)
                {
                    if ((myMemory[j].getName() == "hole") && (myMemory[j].getSize() >= p1.getSize()))
                    {
                        myMemory[j].setName(p1.getName());
                        int tempSize = myMemory[j].getSize();
                        myMemory[j].setSize(p1.getSize());
                        if ((tempSize - p1.getSize()) > 0)
                        {
                            myMemory.Add(new Process((tempSize - p1.getSize()),
                                                  "hole",
                                                   (myMemory[j].getAddress() + p1.getSize())));


                        }
                        sortByAddress();
                        break;

                    }
                }
                if (j < myMemory.Count())
                {
                    string s = "After " + p.getName() + " allocation";
                    toBePrinted(s);
                }
                else if (CompactionModeONRadio.Checked == true)
                {
                    compact(p.getSize());
                    if ((myMemory[myMemory.Count() - 1].getSize() >= p.getSize()) && (myMemory[myMemory.Count() - 1].getName() == "hole"))
                    {
                        myMemory[myMemory.Count() - 1].setName(p.getName());
                        int tempSize = myMemory[myMemory.Count() - 1].getSize();
                        myMemory[myMemory.Count() - 1].setSize(p.getSize());
                        if ((tempSize - p.getSize()) > 0)
                        {
                            myMemory.Add(new Process((tempSize - p.getSize()),
                                                  "hole",
                                                   (myMemory[myMemory.Count() - 1].getAddress() + p.getSize())));
                        }
                        string s = "After " + p.getName() + " allocation with compaction";
                        toBePrinted(s);
                    }
                    else
                    {
                        string s = p.getName() + " could not be allocated..even after compaction";
                        toBePrinted(s);
                    }

                }

                else if (CompactionModeOFFRadio.Checked == true)
                {
                    string s = p.getName() + " could not be allocated..you can deallocate other process and try again";
                    toBePrinted(s);
                }
            }
        }
        
        public void compact(int pSize)
        {
            int totalSize = 0;
            for (int i = 0; i < myMemory.Count(); i++)
            {
                if (myMemory[i].getName() == "hole")
                {
                    totalSize += myMemory[i].getSize();
                    
                }
            }
            if (totalSize >= pSize)
            {
                for (int i = 0; i < myMemory.Count(); i++)
                {
                    if (myMemory[i].getName() == "hole")
                    {

                        if (i != (myMemory.Count() - 1))
                        {
                            myMemory[i + 1].setAddress(myMemory[i + 1].getAddress() - myMemory[i].getSize());
                        }
                        myMemory.RemoveAt(i);
                        i--;
                    }
                }
                myMemory.Add(new Process(totalSize, "hole", (myMemory[myMemory.Count() - 1].getAddress() + myMemory[myMemory.Count() - 1].getSize())));
            }
            
        }



























        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void HoleSizeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        private void ScreeningGroupBox_Enter(object sender, EventArgs e)
        {

        }

        

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        
    }
    

    public class Process
    {
        string Name;
        int Size;
        int Address; 
        public Process(int s, string n, int a)
        {
            Name = n;
            Size = s;
            Address = a;
        }
        public void setName(string n)
        {
            Name = n;
        }
        public string getName()
        {
            return Name;
        }

        public void setSize(int s)
        {
            Size = s;
        }
        public int getSize()
        {
            return Size;
        }

        public void setAddress(int a)
        {
            Address = a;
        }
        public int getAddress()
        {
            return Address;
        }

    }
}
