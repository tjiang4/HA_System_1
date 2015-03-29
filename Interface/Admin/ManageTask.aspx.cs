using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using Engine;
using Engine.BLL;
using Engine.DAL;
using Engine.Entities;

public partial class Admin_ManageTask : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LookupTaskButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(TasksDropDown.Text))
        {
           
        }
        else
        {
            try
            {
                HATask info;
                HazardTaskController systemmgr = new HazardTaskController();
                info = systemmgr.HazardTaskByTaskID(int.Parse(TasksDropDown.Text));
                TaskIDTextBox.Text = info.TaskID.ToString();
                TaskNameTextBox.Text = info.TaskName.ToString();

                char activeInactive = Convert.ToChar(info.Active_YN);

                if (activeInactive == 'Y')
                {
                    // take char Y
                    ActiveDropDown.SelectedValue = "Y";
                }
                else
                {
                    // take char N
                    ActiveDropDown.SelectedValue = "N";
                }


            }
            catch (Exception ex)
            {
               
            }
        }
    }

    protected void AddTaskButton_Click(object sender, EventArgs e)
    {
        CreateTask();
    }

    public void CreateTask()
    {
        MessageUserControl.TryRun(() =>
        {
        HATask task = new HATask()
        {
           
            TaskName = TaskNameTextBox.Text,
            Active_YN = ActiveDropDown.Text
        };

        var controller = new HazardTaskController();
        task.TaskID = int.Parse(controller.Tasks_Add(task));
        }, "Success", "Task has been created.");
    }

    public void UpdateTask()
    {
        MessageUserControl.TryRun(() =>
        {
        HATask task = new HATask()
        {
            TaskID = int.Parse(TaskIDTextBox.Text),
            TaskName = TaskNameTextBox.Text,
            Active_YN = ActiveDropDown.Text
        };

        var controller = new HazardTaskController();
        controller.Tasks_Update(task);
        }, "Success", "Task has been updated.");
    }

    protected void UpdateTaskButton_Click(object sender, EventArgs e)
    {
        UpdateTask();
    }
}