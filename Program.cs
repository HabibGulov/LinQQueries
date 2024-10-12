using CRM.DataContext;
using CRM.Entities;
using CRM.Enums;
using Microsoft.EntityFrameworkCore;

DataContext dataContext = new DataContext();
//Task #2
// var list = from task in dataContext.Tasks 
//                 join comment in dataContext.Comments on task.TaskId equals comment.TaskId
//                 where task.Comments.Count>3 && DateTimeOffset.Now.Month-task.CreatedAt.Month<=2
//                 // group dataContext.Comments by task.TaskId into newGroup
//                 select task;
                
// foreach(var i in list)
// {
//     System.Console.WriteLine(i.TaskName);
// }

//Task #3
// var list = from project in dataContext.Projects //where DateTime.Now.Year-project.CreatedAt.Year<1//
//             join user in dataContext.Users on project.ManagerId equals user.UserId
//             group project by user into userProjects
//             orderby userProjects.Count()
//             select new
//             {
//                 FirstName = userProjects.Key.FirstName,
//                 LastName = userProjects.Key.LastName,
//                 ProjectCount = userProjects.Count()
//             };

// foreach(var i in list)
// {
//     System.Console.WriteLine($"Manager: {i.FirstName} {i.LastName}; ProjectCount: {i.ProjectCount}");
// }

//Task #4
// var list = from task in dataContext.Tasks
//             join user in dataContext.Users on task.AssignedToId equals user.UserId
//             where DateTime.Now.Day-task.CreatedAt.Day>30 && task.Status==CRM.Enums.TaskStatus.Assigned
//             select task;
// foreach(var i in list)
// {
//     System.Console.WriteLine(i.Description);
// }

//Task #5
// var projects = from project in dataContext.Projects 
//                 join task in dataContext.Tasks on project.ProjectId equals task.ProjectId
//                 group task by project into taskGroups 
//                 select new
//                 {
//                     taskGroups.Key
//                 };

//Task #8
// var projects = from project in dataContext.Projects
//                 join task in dataContext.Tasks on project.ProjectId equals task.ProjectId
//                 group task by project into newGroup
//                 select new
//                 {
//                     Project=newGroup.Key.ProjectName,
//                     Tasks = newGroup.Key.Tasks
//                 };

// foreach(var i in projects)
// {
//     System.Console.WriteLine(i.Project);
//     foreach(var j in i.Tasks)
//     {
//         System.Console.Write(j.Description+" ");
//     }
//     System.Console.WriteLine();
// }       

//Task #9
// var list = from user in dataContext.Users
//             join task in dataContext.Tasks on user.UserId equals task.AssignedToId
//             where user.AssignedTasks.Count()>2 && task.Status != CRM.Enums.TaskStatus.InProgress
//             select task;