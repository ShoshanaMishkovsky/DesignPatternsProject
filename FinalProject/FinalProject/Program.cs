using FinalProject;

User user = new("Shoshi Mishkovsky", 90471);
User user1 = new("Esti Turner", 7895);
User user2 = new("Ruth Levy", 96853);
User user3 = new("Dina Cohen", 6354);
User user4 = new("Chana Israeli", 7856324);


user.CreateABranch("React Project", "main");
user.BranchItems[0].Collaborators.Add(user1);
user.BranchItems[0].Collaborators.Add(user2);
user.BranchItems[0].Collaborators.Add(user4);


user1.CreateABranch("Python Project", "main");
user1.BranchItems[0].Collaborators.Add(user);
user1.BranchItems[0].Collaborators.Add(user3);
user1.BranchItems[0].Collaborators.Add(user4);

user1.CreateABranch("Python Project", "development");

FolderComposite folder = new FolderComposite("React");
FolderComposite folder2 = new FolderComposite("Python");

ItemContext reactFile = new FinalProject.File("app.js");
ItemContext reactFile2 = new FinalProject.File("index.js");
folder.Items.Add(reactFile);
folder.Items.Add(reactFile2);

FolderComposite lesson1 = new("Lesson1");
FolderComposite lesson2 = new("Lesson2");

ItemContext pythonFile = new FinalProject.File("exe1.pyp");
ItemContext pythonFile2 = new FinalProject.File("exe1.pyp");
lesson1.Items.Add(pythonFile);
lesson2.Items.Add(pythonFile2);
folder2.Items.Add(lesson1);
folder2.Items.Add(lesson2);

user.BranchItems[0].AddFile(folder);
user1.BranchItems[0].AddFile(folder2);

user.BranchItems[0].Backup();
user.Add("React Project");
user.BranchItems[0].Backup();
user.Commit("React Project");
user.BranchItems[0].Backup();
user.RequestAReview("React Project");
user.BranchItems[0].Backup();
user.Push("React Project");
user.BranchItems[0].Backup();
user.Invoker.PrintActions();

user1.BranchItems[0].Backup();
user1.Add("Python Project");
user1.BranchItems[0].Backup();
user1.Commit("Python Project");
user1.BranchItems[0].Backup();
user1.RequestAReview("Python Project");
user1.BranchItems[0].Backup();
user1.Push("Python Project");
user1.BranchItems[0].Backup();
user1.Invoker.PrintActions();

user1.BranchItems[1].Backup();
user1.Add("Python Project");
user1.BranchItems[1].Backup();
user1.Commit("python project");
user1.BranchItems[1].Backup();
user1.RequestAReview("python project");
user1.BranchItems[1].Backup();
user1.Push("python project");
user1.BranchItems[1].Backup();
user1.Merge("python project", "development");

user1.BranchItems[0].items[0].ShowHistory();


user1.Invoker.PrintActions();
