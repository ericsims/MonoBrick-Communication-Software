/*
 * This file is part of VLCSHARP.
 *
 * VLCSHARP is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * VLCSHARP is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with VLCSHARP.  If not, see <http://www.gnu.org/licenses/>.
 * 
 * Copyright 2012 Caprica Software Limited.
 */

using System;

namespace Caprica.VlcSharp.MediaList.Events {

    /**
     * Encapsulation of a media list item added event.
     */
    class MediaListItemAddedEvent : AbstractMediaListEvent {
    
        /**
         * Native media instance that was added.
         */
        private readonly IntPtr mediaInstance;
        
        /**
         * Index at which the item was added.
         */
        private readonly int index;
        
        /**
         * Create a media list event.
         * 
         * @param mediaList media list the event relates to
         * @param mediaInstance native media instance that was added
         * @param index index at which the item was added
         */
        protected internal MediaListItemAddedEvent(MediaList mediaList, IntPtr mediaInstance, int index) : base(mediaList) {
            this.mediaInstance = mediaInstance;
            this.index = index;
        }
    
        public override void Notify(MediaListEventListener listener) {
            listener.MediaListItemAdded(mediaList, mediaInstance, index);
        }
    }
}
