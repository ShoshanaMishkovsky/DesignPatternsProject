using FinalProject;

User user = new("Shoshi Mishkovsky", 90471);
User user1 = new("Esti Turner", 7895);
User user2 = new("Yocheved Levy", 96853);
User user3 = new("Dina Cohen", 6354);
User user4 = new("Chana Israeli", 7856324);

user.CreateABranch("project", "project", "main");
user.BranchItems[0].Collaborators.Add(user1);
user.BranchItems[0].Collaborators.Add(user2);
user.BranchItems[0].Collaborators.Add(user4);
ItemContext file = new FinalProject.File("app.js");
user.BranchItems[0].AddFile(file);
user.Commit("project");
user.Invoker.PrintActions();


