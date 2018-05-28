﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnC
{
    public partial class PointerTest : Form
    {
        LearnCDataContext DB = new LearnCDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\STUDY\7TH SEMESTER\Object Oriented Programming 2\Project\Codes\LearnC\LearnC\LearnC.mdf;Integrated Security=True;Connect Timeout=30");

        public int duration = 60;

        public PointerTest()
        {
            InitializeComponent();
        }

        private void q1submit_Click(object sender, EventArgs e)
        {
            bool ans = q101.Checked;
            if (ans == true)
            {
                Profile.Score++;

                var query = from o in DB.UserInfos
                            where o.UserName == LogIn.loginName
                            select o;

                UserInfo user = new UserInfo();
                user = query.First();

                user.Score = Profile.Score + 1;
                DB.SubmitChanges();
                MessageBox.Show("The answer is correct.");
            }
            else
            {
                MessageBox.Show("The answer is wrong");
            }
            q1submit.Enabled = false;
        }

        private void q2submit_Click(object sender, EventArgs e)
        {
            bool ans = q202.Checked;
            if (ans == true)
            {
                Profile.Score++;

                var query = from o in DB.UserInfos
                            where o.UserName == LogIn.loginName
                            select o;

                UserInfo user = new UserInfo();
                user = query.First();

                user.Score = Profile.Score + 1;
                DB.SubmitChanges();
                MessageBox.Show("The answer is correct.");
            }
            else
            {
                MessageBox.Show("The answer is wrong");
            }
            q2submit.Enabled = false;
        }

        private void q3submit_Click(object sender, EventArgs e)
        {
            bool ans = q301.Checked;
            if (ans == true)
            {
                Profile.Score++;

                var query = from o in DB.UserInfos
                            where o.UserName == LogIn.loginName
                            select o;

                UserInfo user = new UserInfo();
                user = query.First();

                user.Score = Profile.Score + 1;
                DB.SubmitChanges();
                MessageBox.Show("The answer is correct.");
            }
            else
            {
                MessageBox.Show("The answer is wrong");
            }
            q3submit.Enabled = false;
        }

        private void q4submit_Click(object sender, EventArgs e)
        {
            bool ans = q401.Checked;
            if (ans == true)
            {
                Profile.Score++;

                var query = from o in DB.UserInfos
                            where o.UserName == LogIn.loginName
                            select o;

                UserInfo user = new UserInfo();
                user = query.First();

                user.Score = Profile.Score + 1;
                DB.SubmitChanges();
                MessageBox.Show("The answer is correct.");
            }
            else
            {
                MessageBox.Show("The answer is wrong");
            }
            q4submit.Enabled = false;
        }

        private void q5submit_Click(object sender, EventArgs e)
        {
            bool ans = q502.Checked;
            if (ans == true)
            {
                Profile.Score++;

                var query = from o in DB.UserInfos
                            where o.UserName == LogIn.loginName
                            select o;

                UserInfo user = new UserInfo();
                user = query.First();

                user.Score = Profile.Score + 1;
                DB.SubmitChanges();
                MessageBox.Show("The answer is correct.");
            }
            else
            {
                MessageBox.Show("The answer is wrong");
            }
            q5submit.Enabled = false;
        }

        private void buttonPointerFinish_Click(object sender, EventArgs e)
        {
            Profile.Finish++;

            var query = from o in DB.UserInfos
                        where o.UserName == LogIn.loginName
                        select o;

            UserInfo user = new UserInfo();
            user = query.First();

            user.ChapterCompleted = Profile.Finish;
            DB.SubmitChanges();
            buttonPointerFinish.Enabled = false;

            this.Hide();
            TestTopics test = new TestTopics();
            test.buttonbasictest.Enabled = false;
            test.buttonconditiontest.Enabled = false;
            test.buttonlooptest.Enabled = false;
            test.buttonarraytest.Enabled = false;
            test.buttonpointertest.Enabled = false;
            test.buttonfunctiontest.Enabled = true;
            test.buttonCertificate.Enabled = false;
            test.Show();
        }

        private void PointerTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void PointerTest_Load(object sender, EventArgs e)
        {

        }

        private void timerPointer_Tick(object sender, EventArgs e)
        {
            duration--;
            textBoxPointer1.Text = duration.ToString();
            textBoxPointer2.Text = duration.ToString();
            if (duration == 0)
            {
                timerPointer.Stop();
                if (buttonPointerFinish.Enabled == false)
                {

                }
                else
                {
                    MessageBox.Show("Time Out.");
                    Profile.Finish++;

                    var query = from o in DB.UserInfos
                                where o.UserName == LogIn.loginName
                                select o;

                    UserInfo user = new UserInfo();
                    user = query.First();

                    user.ChapterCompleted = Profile.Finish;
                    DB.SubmitChanges();
                    buttonPointerFinish.Enabled = false;

                    this.Hide();
                    TestTopics test = new TestTopics();
                    test.buttonbasictest.Enabled = false;
                    test.buttonconditiontest.Enabled = false;
                    test.buttonlooptest.Enabled = false;
                    test.buttonarraytest.Enabled = false;
                    test.buttonpointertest.Enabled = false;
                    test.buttonfunctiontest.Enabled = true;
                    test.buttonCertificate.Enabled = false;
                    test.Show();
                }
            }
        }
    }
}
