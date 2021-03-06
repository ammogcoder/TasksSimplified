/*
 * Copyright (C) 2010 Johan Nilsson <http://markupartist.com>
 *
 * Original (https://github.com/johannilsson/android-actionbar) Ported to Mono for Android
 * Copyright (C) 2012 Tomasz Cielecki <tomasz@ostebaronen.dk>
 * 
 * Modified by James Montemagno Copyright 2012 http://www.montemagno.com
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 */

using Android.Content;
using Android.Views;
using TasksSimplified.ActionBar;

namespace TasksSimplified
{
    /**
         * Definition of an action that could be performed, along with a icon to
         * show.
         */
    public abstract class ActionBarAction : Java.Lang.Object, IActionBarAction
    {
        protected int mDrawable;
        protected Context mContext;
        protected Intent mIntent;

        public abstract int GetDrawable();

        public abstract void PerformAction(View view);

        public int CurrentPosition { get; set; }
        public int PopUpMessage { get; set; }

        public ActionType ActionType { get; set; }
    }
}