using System;
using XFGoogleMapSample.Droid;
using XFGoogleMapSample.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(OfflineTileService))]

namespace XFGoogleMapSample.Droid
{
    /// <summary>
    /// implementation of the offline tile service.
    /// </summary>
    public class OfflineTileService : ITileService
    {
        #region Implementation of ITileService

        /// <summary>
        /// get the tile for the given zoom level and x/y coordinate.
        /// </summary>
        /// <param name="zoom"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public byte[] GetTile(int zoom, int x, int y)
        {
           throw new NotImplementedException();
        }

        #endregion
    }
}