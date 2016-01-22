using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PivotText
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 
 

    public sealed partial class MainPage : Page
    {
        const int numPages = 6;

        string[] shortText = new string[numPages]; // stores the short version
        string[] longText = new string[numPages]; // stores the long version
        Grid[] grids = new Grid[numPages]; // stores the grids we disable and enable
        Grid[] fullTextGrids = new Grid[numPages];
        TextBlock[] textBlocks= new TextBlock[numPages]; // store the text boxes we'll be filling
        TextBlock[] textBlocksFullText = new TextBlock[numPages]; // store the text boxes we'll be filling

        public MainPage()
        {
            this.InitializeComponent();
            fillText(); // fills up the text
        }

        public void fillText() {

            textBlocksFullText[0] = item1FullText;
            textBlocksFullText[1] = item2FullText;
            textBlocksFullText[2] = item3FullText;
            textBlocksFullText[3] = item4FullText;
            textBlocksFullText[4] = item5FullText;
            textBlocksFullText[5] = item6FullText;

            textBlocks[0] = page1Text;
            textBlocks[1] = page2Text;
            textBlocks[2] = page3Text;
            textBlocks[3] = page4Text;
            textBlocks[4] = page5Text;
            textBlocks[5] = page6Text;

            grids[0] = item1Grid;
            grids[1] = item2Grid;
            grids[2] = item3Grid;
            grids[3] = item4Grid;
            grids[4] = item5Grid;
            grids[5] = item6Grid;

            fullTextGrids[0] = fullText1;
            fullTextGrids[1] = fullText2;
            fullTextGrids[2] = fullText3;
            fullTextGrids[3] = fullText4;
            fullTextGrids[4] = fullText5;
            fullTextGrids[5] = fullText6;

            shortText[0] = "The 4G Mobile Phone as the name suggests, is a follower of left off. 4G smart phone stand for Forth Generation of Cellular Communications.";
            longText[0] = "The 4G Mobile Phone as the name suggests. 4G smart phone stand for Forth Generation of Cellular Communications, this means it is next step in evolution of mobile data. The smart  valuable machine for smart business links, used in every day communication, and is packed with many features and internet connections, social networks and many more. What are the benefits of 4G smart phone ? The greatest benefit of 4G smart phone is the rate of speed of processing information at lest it will upwards of 10 times faster than current 3G networks speed.";

            shortText[1] = "The mobile phone networks will replace your contract phone with any of your favorite handset without changing your number.";
            longText[1] = "The mobile phone networks will replace your contract phone with any of your favorite handset without changing your number. You can also extend your contract with these mobile phone networks. These mobile phone networks also allow you to change your mobile phone plan with your new upgraded handset. Mobile phone networks has introduced this mobile upgrade deal just for its customers who love to go for contract deals but just shop thinking about these deals as they cant keep a handset for a long time. So dears if you are also one of them than now no need to worry about this issue. You can also get many benefits with your upgrade handset like free texts, free talk times, free Internet access up to a specified limit and many more.";

            shortText[2] = "The origin of this gadget is quite interesting. Starting from bulky mobile phone which were as long as long and heavy as forearms.";
            longText[2] = "The origin of this gadget is quite interesting.Starting from bulky mobile phone which were as long as long and heavy as forearms.Nowadays mobile phone is ultra thin, and in near future will be more thin than ever. It all started with the basic telephony.Alexander Graham Bell was the first one to patent telephone in the year 1876.The technology was developed using the equipment designed for telegraph.Calls were connected with the help of an operators.Mobile telephony came into existence when Stevenson invented radio communication in early 1890's for keeping contacts with offshore lighthouses.  A man talks on his mobile phone while standing near a conventional telephone box, which stands empty.Enabling technology for mobile phones was first developed in the 1940's.";

            shortText[3] = "Getting a 4G phone is a big investment for most people, so losing that brand new smart phone due to carelessness or theft is a major disappointment.";
            longText[3] = "Getting a 4G phone is a big investment for most people, so losing that brand new smart phone due to carelessness or theft is a major disappointment. Even with the great deals that many cell phone companies have these days on 4G phones, losing one is not like misplacing a hairbrush or a pair of gloves. Replacing it is a hassle, and there is always the slight feeling of anger that someone else out there is probably using the high tech device that you paid for with your hard earned money! Picture If your budget increase is enough, the high performance 4G phone is much more for consumer choice. In addition to some high profile brand, some new brands are worth consumer attention.";
            shortText[4] = "We are living in the world of mobile technology, doing away with old ideas, new business ideas travailing all the whole world.";
            longText[4] = "We are living in the world of mobile technology, doing away with old ideas, new business ideas travailing all the whole world with mobile phone different devices, that makes it fascinating, everyday new idea is been born and people every where are buying into it just as it's  coming, people are studying hard to make more and more change to the system of mobile device. I'm writing about the change this new mobile technology is creating in the whole world of business, just for a second imagine you without a mobile phone, mobile phone have made communication more easy, both for business and social life, for example: 'if there is no mobile communication, how do you reach to the family members when you are away from home, mobile phones makes it possible to communicate with relatives and friends.";

            shortText[5] = "The iPhone 6S Plus has a screen of 5 inches wide, meanwhile the iPhone 6S has a 7 inch screen. If you are looking for a bigger screen.";
            longText[5] = "The iPhone 6S Plus has a screen of 5 inches wide, meanwhile the iPhone 6S has a 7 inch screen. If you are looking for a bigger screen, then you should definitely upgrade to the iPhone 6S Plus. However, there were some who bought it and then realized that the size of the iPhone 6S Plus was too big after a few days of using it.ese phones will generally include these great features. Today I will talk about mobile costs.Mobile phones are expensive to buy and people use a lot of them, people change their mobile phone so often, sometimes due to newer modern and sometimes due to damage. iPhone six plus one of the most expensive phone in the market today is Apple's latest phone in the market,it is great phone, size wise very slim compare to other phones.";

            for (int i = 0; i < numPages; i++) {
                textBlocks[i].Text = shortText[i];
                textBlocksFullText[i].Text = longText[i];
            }


        } // fill text

        private void _0Button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Button b = (Button)sender; // cast the sender as a button
            double num = Char.GetNumericValue(b.Name[1]); // this number is the position in the arrays
           // page1Text.Text = num.ToString();

            grids[(int)num].Visibility = Visibility.Collapsed; // hides grid
            fullTextGrids[(int)num].Visibility = Visibility.Visible; // shows full text

        }

        private void FullText_Tapped(object sender, TappedRoutedEventArgs e)
        {
             TextBlock b = (TextBlock)sender; // cast the sender as a button
            double num = Char.GetNumericValue(b.Name[4]) - 1; // this number is the position in the arrays

            grids[(int)num].Visibility = Visibility.Visible; // hides grid
            fullTextGrids[(int)num].Visibility = Visibility.Collapsed; // shows full text
        } // fullTextTapped
    }
}
