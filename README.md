# SmartExplorer
Smartly browse and select files from Build & Editor

Email : support@electronicbrain.net 


# How to use
Simply copy Plugin folder to your Asset/ folder or open Unity Package. Or, you can clone/download Project File and open the project. For, any edit in plugin, clone source and open in Visual Studio. Learn how to play with DLL : http://bit.ly/2kfBTBx .

Follow this tutorial for implementing SmartExplorer in your project. 

• **How to Show/Open Explorer** 

Call SmartFileExplorer.OpenExplorer() function for Show/Open Explorer. Here is example : 

```
    public SmartFileExplorer fileExplorer = new SmartFileExplorer();

    void ShowExplorer()
    {
        string initialDir = @"C:\";
        bool restoreDir = true;
        string title = "Open a Text File";
        string defExt = "txt";
        string filter = "txt files (*.txt)|*.txt";

        fileExplorer.OpenExplorer(initialDir,restoreDir,title,defExt,filter);
        readText = true;
    }
```
Don't forget to add SmartDLL namespace. 

• **How to selected File Path with their extension?**

Basically, SmartFileExplorer.fileName store selected file directory with extension. Where, SmartFileExplorer.filePath is just store directory of that selected file. Example:

```
   string fileDir = fileExplorer.filePath; //Dir
   string filePath = fileExplorer.fileName; //Dir with Extension and Name
```

# Contribution 
This project is free to use. You can make changes and make it better. Your name will be added to Credit. But, Reproduction is strictly prohibated.

# About SmartDLL 
SmartDLL is a collection of neccessary managed plugin that we need to develop our desired project. But sometimes, some thing is so deep or complex that has never done before or rarely but not available for everyone. 
Electronic Brain will develop those rare things from community's feedback. So your feedback and contribution is so helpful for us. Your donation will effect our development speed. We will be able to focus on Programming. Donation information has given below. 

# About Electronic Brain 
Electronic brain is a Game Studio based on Bangladesh. Currently, we have 2 Programmers and a Doctor who actually give us creative idea to work on. We're always looking forward to working with a Creative Person. Please notify us if you want to Join us,

# Task List
- [x] Build Friendly

We will develop the following tasks. If any features need to be added, please mail to support@electronicbrain.net . 

# Contributors 
 >**Srejon Khan**
 
 Game Programmer, Electronic Brain 
 
Using Unity over 4 years. Use C# and PHP,MySQL for backend. Worked on various client project and games. Worked as Assistant programmer in DR.Paedi and Lead Programmer in Last Breath.  

 >**Ashikur Rahman** 
 
 Game Programmer, Electronic Brain 
 
Using Unity over 3 years. Use C# and PHP,MySQL for backend.Worked on various client project and games. Successfull Lead Programmer in DR.Paedi and Assistant Programmer in Last Breath.  

# Support
Donate us for developing any project without any trouble. We need more Programmers and Artists to work on various project and gifting something better to everyone. (All the money you donate is spent for Developing and Electronic Brain and not for any personal uses.)

**Support Us at Patreon:** https://www.patreon.com/ElectronicBrain

**Youtube:** https://www.youtube.com/electronicbrain/ 

**Website:** http://electronicbrain.net/ 

**Facebook:** https://facebook.com/electronicbrainpage

**Instagram:** https://instagram.com/electronicbrainteam


Have a Nice Day.
