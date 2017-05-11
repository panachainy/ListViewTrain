﻿using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace ListViewTrain {
	[Activity(Label = "ListViewTrain", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity {
		ListView listShow;
		List<DataModel> userList;

		protected override void OnCreate(Bundle savedInstanceState) {
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);
			process();
		}

		public void process() {
			//userList = new List<DataModel>();

			//string[] image = { "http://i.imgur.com/DvpvklR.png", "http://i.imgur.com/DvpvklR.png", "http://i.imgur.com/DvpvklR.png" };
			//string[] title = { "test 1", "test 2", "test 3", };
			//string[] des = { "des 1", "des 2", "des 3", };

			//userList = image.Split(',').ToList();

			userList = new List<DataModel>();

			userList.Add(new DataModel() {
				Image = "http://i.imgur.com/DvpvklR.png",
				Title = "รูปที่ 2",
				Des = "เทสภาษาไทย"
			});

			userList.Add(new DataModel() {
	Image = "http://i.imgur.com/DvpvklR.png",
				Title = "รูปที่ 1",
				Des = "ทำอะไรได้บ้าง"
			});

			listShow = FindViewById<ListView>(Resource.Id.lvShow);


			CustomListView employeeProfileAdapter = new CustomListView(this, userList);
			listShow.Adapter = employeeProfileAdapter;


		}
	}

}