using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kovrik
{
    public partial class Form1 : Form
    {
        
        const string helpfile = "Выложите карты в последовательности одной масти от туза до короля.   В четыре левые ячейки можно положить любого туза.   В свободную ячейку можно положить карту той же масти, что и карта, лежащая слева от этой ячейки, но на единицу большего достоинства.  Если слева от свободной ячейки лежит король или другая свободная ячейка, то в неё ничего нельзя положить.В пасьянce карты можно перемешивать 3 раза";
        const int ROW_COUNT = 4;  // количество рядов
        const int COL_COUNT = 14;  // количество столбцов
        const int LEFT = 120;      // координаты верхнего левого угла
        const int TOP = 120;
        const int CARD_WIDTH = 72;    // ширина карты
        const int CARD_HEIGHT = 100;  // высота карты
        const int H_SHIFT = CARD_WIDTH + 10;    // сдвиг между стопками по горизпнтали
        const int V_SHIFT = CARD_HEIGHT + 40;   // сдвиг между рядами по вертикали
        const int emptyCard = 52;   // индекс изображения пустой карты

        private bool newGame=false;
        private bool close = false;
        private int a;
        private int three = 0;
        private Place[,] Places;  // 4 ряда по 13 стопок
        private Deck deck;      // колода


        private bool drag = false;      // флаги выполнения drag & drop
        private Graphics grf;
        private SolidBrush backBrush;

        private Card dragCard = null;      // перемещаемая карта
        private int dragX, dragY;   // координаты перемещаемой карты
        private int deltaX, deltaY; // разница между координатами перемещаемой карты и координатами курсора на ней 
        private int dragRow;    // ряд, с которого перемещается карта 
        private int dragCol;    // столбец, с которого перемещается карта 
        private int dropRow;  // ряд, на который перемещается карта 
        private int dropCol;   // столбец, на который перемещается карта 
       

        public Form1()
        {
            InitializeComponent();
        }
        private bool CanDo() //можно ли сделать ход
        {
            for (int row = 0; row < ROW_COUNT; row++)
            {
                for (int col = 0; col < COL_COUNT; col++)
                {
                    if ((Places[row, col].Card.ImageIndex == emptyCard))
                        if (col == 0) return true;
                        else
                        {    
                            foreach (var e in Places)
                            {
                                if (!(e.Card.ImageIndex == emptyCard))
                                    if (!e.onplace)
                                    {
                                        if (((e.Card.Rank - Places[row, col - 1].Card.Rank) == 1) && (Places[row, col - 1].Card.Suit == e.Card.Suit))
                                        {
                                            return true;
                                        }
                                    }
                            }
                        }
                }
            }
            
            return false;
        }

        private void ShowAll(Graphics g) //Рисуем карты
        {
            if (!close)
            {

                for (int row = 0; row < ROW_COUNT; row++)
                {
                    for (int col = 0; col < COL_COUNT; col++)
                    {
                        onPlace();

                        if (IsVictory())
                        {
                            MessageBox.Show("Вы выиграли!:)", "Пасьянс Mod3");
                            Closegame();
                        }
                        else
                        {
                            if (Places[row, col].onplace)
                                imageList1.Draw(g, Places[row, col].X, Places[row, col].Y, Places[row, col].Card.ImageIndex + 53);

                            else
                                imageList1.Draw(g, Places[row, col].X, Places[row, col].Y, Places[row, col].Card.ImageIndex);
                        }
                    }
                    // прорисовка перемещаемой карты
                    if (drag)
                    {
                        imageList1.Draw(g, dragX, dragY, dragCard.ImageIndex);
                    }
                }
            }

        }

        private void onPlace() //проверка на месте ли карта
        {
            for (int row = 0; row < ROW_COUNT; row++)
               {
                  for (int col = 1; col < COL_COUNT; col++)
                     {  
                      Places[row, col].onplace=(Places[row,col].num == Places[row,col].Card.Rank && Places[row,col].suit == Places[row,col].Card.Suit && Places[row,col - 1].onplace);
                  }
            }
        }
        private void Change() //перемешать карты по полю
        {
            if (three < 3)
            {
                if ((CanDo()))
                {
                    MessageBox.Show("Есть возможные ходы");
                }
                else

               {
                        three++;
                        Card card = new Card(0, 0);
                        deck.clear();
                        foreach (var e in Places)
                        {
                           if (!e.onplace && !(e.Card.ImageIndex== emptyCard)) deck.AddCard(e.Card);
                        }
                        deck.Shuffle();
                        bool f=true;
                        for (int row = 0; row < ROW_COUNT; row++)
                        {
                            for (int col = 1; col < COL_COUNT; col++)
                            {
                                if (f)
                                {
                                    if (!Places[row, col].onplace)
                                    {
                                        f = false;
                                        Places[row, col].Card = new Card(emptyCard);
                                        
                                    }
                                }
                                else
                                {
                                    card = deck.GetCard();

                                    Places[row, col].Card = card;

                                }
                            }
                            f = true;
                        }
                       Invalidate();
                     
                    }
                }
            else
                if ((CanDo()))
                    MessageBox.Show("Еще есть ходы");
                else
                {
                    
                    MessageBox.Show("Вы проиграли :( ");
                    Closegame();

                }
                

               
            }

        private void Closegame() //окончание игры
        {
            close = true;
            Invalidate();
        }
        

   
        private void NewGame()
        {

            deck = new Deck();
           
            deck.Shuffle();


            Places = new Place[ROW_COUNT, COL_COUNT];
            newGame = true;
            Card card = new Card(0, 0);
      
            for (int row = 0; row < ROW_COUNT; row++)
            {
                for (int col = 0; col < COL_COUNT; col++)
                {
                    Places[row, col] = new Place();
                    Places[row, col].X = LEFT + H_SHIFT * col;
                    Places[row, col].Y = TOP + V_SHIFT * row;
                    Places[row, col].num = col;

                    if (col == 0)
                        Places[row, col].Card = new Card(emptyCard);
                    else
                    {
                        card = deck.GetCard();
                        Places[row, col].Card = card;

                    }


                }
            }

            Invalidate();
          
        }

        private void играToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void новаяИграToolStripMenuItem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (newGame) ShowAll(e.Graphics);
        }

        

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            if (newGame)
            {
                if (drag)
                {
                    dragX = e.X - deltaX;
                    dragY = e.Y - deltaY;
                    Invalidate();
                }
            }

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (newGame)
            {
                if (drag)
                {
                    if (CanDrop(e.X, e.Y))
                    {
                        Places[dropRow, dropCol].Card = new Card(a);
                        

                        if (Places[dropRow, dropCol].Card.Rank == 0)
                        {
                            Places[dropRow, dropCol].onplace = true;
                            for (int col = 0; col < COL_COUNT; col++)
                                Places[dropRow, col].suit = Places[dropRow, dropCol].Card.Suit;
                        }
                    
                    }
                    else
                        Places[dragRow, dragCol].Card = new Card(a);
                        
                    


                    dragCard = null;
                    dragRow = -1;
                    dragCol = -1;
                    dropRow = -1;
                    dropCol = -1;
                    dragX = -1;
                    dragY = -1;
                    drag = false;
                    

                   
                    Invalidate();
                }
            }
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        { 
            if (newGame)
            {
                a = CaptureCard(e.X, e.Y); // перемещаемая карта

                 if (a >= 0 && a < emptyCard)
                {
                    if (!Places[dragRow, dragCol].onplace)
                    {
                        dragCard = new Card(a);
                        deltaX = e.X - dragX;
                        deltaY = e.Y - dragY;
                        drag = true;
                        
                        Places[dragRow, dragCol].Card = new Card(emptyCard);
                        if ((!CanDo()) && (three >= 3))
                        {
                            MessageBox.Show("Вы проиграли :( ");
                            Closegame();
                        }

                        
                        
                        Invalidate();
                    }
                }

            }
        }

        private bool IsVictory()
        {
            bool n=true;
            for (int row = 0; row < ROW_COUNT; row++)
            {
                for (int col = 0; col < COL_COUNT - 1; col++)
                {
                    n = n && (Places[row, col].onplace);
                }
            }
            return n;
        }
        private bool CanDrop(int x, int y) //можно переместить?
        {
           dropCol= CaptureCol(x);
           dropRow = CaptureRow(y);
           
           int i=a % Constants.RANK_COUNT;
           int j=a/Constants.RANK_COUNT;

          if (dropCol >= 0 && dropRow >= 0)
            {
                if (Places[dropRow, dropCol].Card.ImageIndex == emptyCard)
                    if (dropCol == 0) return (i == 0 || a == 0);
                    else return ((a-Places[dropRow, dropCol - 1].Card.ImageIndex)==1 &&
                        Places[dropRow, dropCol - 1].Card.Suit == j);  
            }

          return false;

        }

        

        private int CaptureCard(int x, int y) //захват карты
        {
            int card = -1;

            for (int row = 0; row < ROW_COUNT; row++)
            {
                for (int col = 0; col < COL_COUNT; col++)
                {
                    if ((x >= Places[row, col].X) && (x <= (Places[row, col].X + CARD_WIDTH)) && (y >= Places[row, col].Y) && (y <= (Places[row, col].Y + CARD_HEIGHT)))
                    {
                        dragCol = col;
                        dragRow = row;
                        dragX = Places[dragRow, dragCol].X;
                        dragY = Places[dragRow, dragCol].Y;
                        card = Places[dragRow, dragCol].Card.ImageIndex;

                        return card;
                    }
                }
            }
            return card;
        }

        private int CaptureRow(int y)
        {
            for (int row = 0; row < ROW_COUNT; row++)
            {
                    if ((y >= Places[row, 0].Y) && (y <= (Places[row, 0].Y + CARD_HEIGHT)))
                    {
                       return row;
                    }
            }
            return -1;

        }
        private int CaptureCol(int x)
        {
            for (int col = 0; col < COL_COUNT; col++)
            {
                if ((x >= Places[0, col].X) && (x <= (Places[0, col].X + CARD_WIDTH)))
                {
                    return col;
                }
            }
            return -1;

        }

        private void перемешатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (newGame)
            Change();
        }

        private void описаниеПасьянсаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(helpfile, "Правила пасьянса");
        }


    }
}
    


