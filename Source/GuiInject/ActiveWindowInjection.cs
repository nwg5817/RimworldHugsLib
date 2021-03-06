﻿using System;

namespace HugsLib.GuiInject {
	// Created by WindowInjectionManager and used for data storage
	public class ActiveWindowInjection {
		public readonly string injectionId;
		public readonly Type windowType;
		public readonly WindowInjectionManager.InjectMode mode;
		public readonly WindowInjectionManager.DrawInjectedContents callback;

		public ActiveWindowInjection(string injectionId, Type windowType, WindowInjectionManager.InjectMode mode, WindowInjectionManager.DrawInjectedContents callback) {
			this.injectionId = injectionId;
			this.windowType = windowType;
			this.mode = mode;
			this.callback = callback;
		}
	}
}