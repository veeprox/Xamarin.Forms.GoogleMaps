namespace XFGoogleMapSample.Interfaces
{
    /// <summary>
    /// the tile service interface. This service provides access to cached local tiles.
    /// </summary>
    public interface ITileService
    {
        /// <summary>
        /// get the tile for the given zoom level and x/y coordinate.
        /// </summary>
        /// <param name="zoom"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        byte[] GetTile(int zoom, int x, int y);
    }
}
