﻿namespace Imgur.API.Tests.Mocks
{
    public class MockNotificationEndpointResponses
    {
        public const string GetNotification =
            "{\"data\":{\"id\":322892525,\"account_id\":24562464,\"viewed\":true,\"content\":{\"id\":544080581,\"image_id\":\"BJRWQw5\",\"comment\":\"Create Comment with Parent\",\"author\":\"imgurapidotnet\",\"author_id\":24562464,\"on_album\":false,\"album_cover\":null,\"ups\":1,\"downs\":0,\"points\":1,\"datetime\":1451046306,\"parent_id\":540767605,\"deleted\":false,\"vote\":null,\"platform\":\"2\",\"children\":[]}},\"success\":true,\"status\":200}";

        public const string GetNotifications =
            "{\"data\":{\"replies\":[{\"id\":322892525,\"account_id\":24562464,\"viewed\":false,\"content\":{\"id\":544080581,\"image_id\":\"BJRWQw5\",\"comment\":\"Create Comment with Parent\",\"author\":\"imgurapidotnet\",\"author_id\":24562464,\"on_album\":false,\"album_cover\":null,\"ups\":1,\"downs\":0,\"points\":1,\"datetime\":1451046306,\"parent_id\":540767605,\"deleted\":false,\"vote\":null,\"platform\":\"2\",\"children\":[]}},{\"id\":322888961,\"account_id\":24562464,\"viewed\":false,\"content\":{\"id\":544075061,\"image_id\":\"BJRWQw5\",\"comment\":\"Create Reply\",\"author\":\"imgurapidotnet\",\"author_id\":24562464,\"on_album\":false,\"album_cover\":null,\"ups\":1,\"downs\":0,\"points\":1,\"datetime\":1451045639,\"parent_id\":540767605,\"deleted\":false,\"vote\":null,\"platform\":\"2\",\"children\":[]}},{\"id\":322887901,\"account_id\":24562464,\"viewed\":false,\"content\":{\"id\":544073645,\"image_id\":\"BJRWQw5\",\"comment\":\"Create Comment with Parent\",\"author\":\"imgurapidotnet\",\"author_id\":24562464,\"on_album\":false,\"album_cover\":null,\"ups\":1,\"downs\":0,\"points\":1,\"datetime\":1451045470,\"parent_id\":540767605,\"deleted\":false,\"vote\":null,\"platform\":\"2\",\"children\":[]}},{\"id\":321783453,\"account_id\":24562464,\"viewed\":false,\"content\":{\"id\":542490061,\"image_id\":\"BJRWQw5\",\"comment\":\"Create Reply\",\"author\":\"imgurapidotnet\",\"author_id\":24562464,\"on_album\":false,\"album_cover\":null,\"ups\":1,\"downs\":0,\"points\":1,\"datetime\":1450858946,\"parent_id\":540767605,\"deleted\":false,\"vote\":null,\"platform\":\"2\",\"children\":[]}},{\"id\":321783441,\"account_id\":24562464,\"viewed\":false,\"content\":{\"id\":542490045,\"image_id\":\"BJRWQw5\",\"comment\":\"Create Comment with Parent\",\"author\":\"imgurapidotnet\",\"author_id\":24562464,\"on_album\":false,\"album_cover\":null,\"ups\":1,\"downs\":0,\"points\":1,\"datetime\":1450858944,\"parent_id\":540767605,\"deleted\":false,\"vote\":null,\"platform\":\"2\",\"children\":[]}},{\"id\":321782465,\"account_id\":24562464,\"viewed\":false,\"content\":{\"id\":542488837,\"image_id\":\"BJRWQw5\",\"comment\":\"Create Reply\",\"author\":\"imgurapidotnet\",\"author_id\":24562464,\"on_album\":false,\"album_cover\":null,\"ups\":1,\"downs\":0,\"points\":1,\"datetime\":1450858786,\"parent_id\":540767605,\"deleted\":false,\"vote\":null,\"platform\":\"2\",\"children\":[]}},{\"id\":321781821,\"account_id\":24562464,\"viewed\":false,\"content\":{\"id\":542487917,\"image_id\":\"BJRWQw5\",\"comment\":\"Create Comment with Parent\",\"author\":\"imgurapidotnet\",\"author_id\":24562464,\"on_album\":false,\"album_cover\":null,\"ups\":1,\"downs\":0,\"points\":1,\"datetime\":1450858670,\"parent_id\":540767605,\"deleted\":false,\"vote\":null,\"platform\":\"2\",\"children\":[]}},{\"id\":321777629,\"account_id\":24562464,\"viewed\":false,\"content\":{\"id\":542483005,\"image_id\":\"BJRWQw5\",\"comment\":\"Create Reply\",\"author\":\"imgurapidotnet\",\"author_id\":24562464,\"on_album\":false,\"album_cover\":null,\"ups\":1,\"downs\":0,\"points\":1,\"datetime\":1450857991,\"parent_id\":540767605,\"deleted\":false,\"vote\":null,\"platform\":\"2\",\"children\":[]}},{\"id\":321777093,\"account_id\":24562464,\"viewed\":false,\"content\":{\"id\":542482385,\"image_id\":\"BJRWQw5\",\"comment\":\"Create Comment with Parent\",\"author\":\"imgurapidotnet\",\"author_id\":24562464,\"on_album\":false,\"album_cover\":null,\"ups\":1,\"downs\":0,\"points\":1,\"datetime\":1450857912,\"parent_id\":540767605,\"deleted\":false,\"vote\":null,\"platform\":\"2\",\"children\":[]}},{\"id\":321774685,\"account_id\":24562464,\"viewed\":false,\"content\":{\"id\":542479769,\"image_id\":\"BJRWQw5\",\"comment\":\"Create Reply\",\"author\":\"imgurapidotnet\",\"author_id\":24562464,\"on_album\":false,\"album_cover\":null,\"ups\":1,\"downs\":0,\"points\":1,\"datetime\":1450857564,\"parent_id\":540767605,\"deleted\":false,\"vote\":null,\"platform\":\"2\",\"children\":[]}},{\"id\":321774177,\"account_id\":24562464,\"viewed\":false,\"content\":{\"id\":542479241,\"image_id\":\"BJRWQw5\",\"comment\":\"Create Comment with Parent\",\"author\":\"imgurapidotnet\",\"author_id\":24562464,\"on_album\":false,\"album_cover\":null,\"ups\":1,\"downs\":0,\"points\":1,\"datetime\":1450857476,\"parent_id\":540767605,\"deleted\":false,\"vote\":null,\"platform\":\"2\",\"children\":[]}},{\"id\":321769869,\"account_id\":24562464,\"viewed\":false,\"content\":{\"id\":542474437,\"image_id\":\"BJRWQw5\",\"comment\":\"Create Reply\",\"author\":\"imgurapidotnet\",\"author_id\":24562464,\"on_album\":false,\"album_cover\":null,\"ups\":1,\"downs\":0,\"points\":1,\"datetime\":1450856828,\"parent_id\":540767605,\"deleted\":false,\"vote\":null,\"platform\":\"2\",\"children\":[]}},{\"id\":321768813,\"account_id\":24562464,\"viewed\":false,\"content\":{\"id\":542473241,\"image_id\":\"BJRWQw5\",\"comment\":\"Create Comment with Parent\",\"author\":\"imgurapidotnet\",\"author_id\":24562464,\"on_album\":false,\"album_cover\":null,\"ups\":1,\"downs\":0,\"points\":1,\"datetime\":1450856669,\"parent_id\":540767605,\"deleted\":false,\"vote\":null,\"platform\":\"2\",\"children\":[]}},{\"id\":321766793,\"account_id\":24562464,\"viewed\":false,\"content\":{\"id\":542470769,\"image_id\":\"BJRWQw5\",\"comment\":\"Create Reply\",\"author\":\"imgurapidotnet\",\"author_id\":24562464,\"on_album\":false,\"album_cover\":null,\"ups\":1,\"downs\":0,\"points\":1,\"datetime\":1450856367,\"parent_id\":540767605,\"deleted\":false,\"vote\":null,\"platform\":\"2\",\"children\":[]}},{\"id\":321765989,\"account_id\":24562464,\"viewed\":false,\"content\":{\"id\":542469801,\"image_id\":\"BJRWQw5\",\"comment\":\"Create Comment with Parent\",\"author\":\"imgurapidotnet\",\"author_id\":24562464,\"on_album\":false,\"album_cover\":null,\"ups\":1,\"downs\":0,\"points\":1,\"datetime\":1450856238,\"parent_id\":540767605,\"deleted\":false,\"vote\":null,\"platform\":\"2\",\"children\":[]}},{\"id\":321742161,\"account_id\":24562464,\"viewed\":false,\"content\":{\"id\":542437701,\"image_id\":\"BJRWQw5\",\"comment\":\"Create Reply\",\"author\":\"imgurapidotnet\",\"author_id\":24562464,\"on_album\":false,\"album_cover\":null,\"ups\":1,\"downs\":0,\"points\":1,\"datetime\":1450852603,\"parent_id\":540767605,\"deleted\":false,\"vote\":null,\"platform\":\"2\",\"children\":[]}},{\"id\":321741305,\"account_id\":24562464,\"viewed\":false,\"content\":{\"id\":542436509,\"image_id\":\"BJRWQw5\",\"comment\":\"Create Comment with Parent\",\"author\":\"imgurapidotnet\",\"author_id\":24562464,\"on_album\":false,\"album_cover\":null,\"ups\":1,\"downs\":0,\"points\":1,\"datetime\":1450852483,\"parent_id\":540767605,\"deleted\":false,\"vote\":null,\"platform\":\"2\",\"children\":[]}},{\"id\":321740221,\"account_id\":24562464,\"viewed\":false,\"content\":{\"id\":542434921,\"image_id\":\"BJRWQw5\",\"comment\":\"Create Reply\",\"author\":\"imgurapidotnet\",\"author_id\":24562464,\"on_album\":false,\"album_cover\":null,\"ups\":1,\"downs\":0,\"points\":1,\"datetime\":1450852343,\"parent_id\":540767605,\"deleted\":false,\"vote\":null,\"platform\":\"2\",\"children\":[]}},{\"id\":321739537,\"account_id\":24562464,\"viewed\":false,\"content\":{\"id\":542433965,\"image_id\":\"BJRWQw5\",\"comment\":\"Create Comment with Parent\",\"author\":\"imgurapidotnet\",\"author_id\":24562464,\"on_album\":false,\"album_cover\":null,\"ups\":1,\"downs\":0,\"points\":1,\"datetime\":1450852256,\"parent_id\":540767605,\"deleted\":false,\"vote\":null,\"platform\":\"2\",\"children\":[]}},{\"id\":321574605,\"account_id\":24562464,\"viewed\":false,\"content\":{\"id\":542212501,\"image_id\":\"BJRWQw5\",\"comment\":\"Create Reply\",\"author\":\"imgurapidotnet\",\"author_id\":24562464,\"on_album\":false,\"album_cover\":null,\"ups\":1,\"downs\":0,\"points\":1,\"datetime\":1450833421,\"parent_id\":540767605,\"deleted\":false,\"vote\":null,\"platform\":\"2\",\"children\":[]}},{\"id\":321505325,\"account_id\":24562464,\"viewed\":false,\"content\":{\"id\":542118389,\"image_id\":\"BJRWQw5\",\"comment\":\"Create Comment with Parent\",\"author\":\"imgurapidotnet\",\"author_id\":24562464,\"on_album\":false,\"album_cover\":null,\"ups\":1,\"downs\":0,\"points\":1,\"datetime\":1450825142,\"parent_id\":540767605,\"deleted\":false,\"vote\":null,\"platform\":\"2\",\"children\":[]}},{\"id\":321207937,\"account_id\":24562464,\"viewed\":false,\"content\":{\"id\":541669825,\"image_id\":\"BJRWQw5\",\"comment\":\"Create Reply\",\"author\":\"imgurapidotnet\",\"author_id\":24562464,\"on_album\":false,\"album_cover\":null,\"ups\":1,\"downs\":0,\"points\":1,\"datetime\":1450783677,\"parent_id\":540767605,\"deleted\":false,\"vote\":null,\"platform\":\"2\",\"children\":[]}},{\"id\":321207925,\"account_id\":24562464,\"viewed\":false,\"content\":{\"id\":541669813,\"image_id\":\"BJRWQw5\",\"comment\":\"Create Comment with Parent\",\"author\":\"imgurapidotnet\",\"author_id\":24562464,\"on_album\":false,\"album_cover\":null,\"ups\":1,\"downs\":0,\"points\":1,\"datetime\":1450783675,\"parent_id\":540767605,\"deleted\":false,\"vote\":null,\"platform\":\"2\",\"children\":[]}},{\"id\":321206225,\"account_id\":24562464,\"viewed\":false,\"content\":{\"id\":541667169,\"image_id\":\"BJRWQw5\",\"comment\":\"Create Reply\",\"author\":\"imgurapidotnet\",\"author_id\":24562464,\"on_album\":false,\"album_cover\":null,\"ups\":1,\"downs\":0,\"points\":1,\"datetime\":1450783192,\"parent_id\":540767605,\"deleted\":false,\"vote\":null,\"platform\":\"2\",\"children\":[]}},{\"id\":321205849,\"account_id\":24562464,\"viewed\":false,\"content\":{\"id\":541666645,\"image_id\":\"BJRWQw5\",\"comment\":\"Create Comment with Parent\",\"author\":\"imgurapidotnet\",\"author_id\":24562464,\"on_album\":false,\"album_cover\":null,\"ups\":1,\"downs\":0,\"points\":1,\"datetime\":1450783104,\"parent_id\":540767605,\"deleted\":false,\"vote\":null,\"platform\":\"2\",\"children\":[]}},{\"id\":321133713,\"account_id\":24562464,\"viewed\":false,\"content\":{\"id\":541577965,\"image_id\":\"BJRWQw5\",\"comment\":\"Create Comment with Parent\",\"author\":\"imgurapidotnet\",\"author_id\":24562464,\"on_album\":false,\"album_cover\":null,\"ups\":1,\"downs\":0,\"points\":1,\"datetime\":1450767755,\"parent_id\":540767605,\"deleted\":false,\"vote\":null,\"platform\":\"2\",\"children\":[]}},{\"id\":320548281,\"account_id\":24562464,\"viewed\":false,\"content\":{\"id\":540775933,\"image_id\":\"BJRWQw5\",\"comment\":\"Create Reply\",\"author\":\"imgurapidotnet\",\"author_id\":24562464,\"on_album\":false,\"album_cover\":null,\"ups\":1,\"downs\":0,\"points\":1,\"datetime\":1450678416,\"parent_id\":540767605,\"deleted\":false,\"vote\":null,\"platform\":\"2\",\"children\":[]}},{\"id\":320542613,\"account_id\":24562464,\"viewed\":false,\"content\":{\"id\":540768569,\"image_id\":\"BJRWQw5\",\"comment\":\"Hello World!\",\"author\":\"imgurapidotnet\",\"author_id\":24562464,\"on_album\":false,\"album_cover\":null,\"ups\":1,\"downs\":0,\"points\":1,\"datetime\":1450677571,\"parent_id\":540767605,\"deleted\":false,\"vote\":null,\"platform\":\"2\",\"children\":[]}},{\"id\":320515981,\"account_id\":24562464,\"viewed\":false,\"content\":{\"id\":540733709,\"image_id\":\"BJRWQw5\",\"comment\":\"Fail\",\"author\":\"Wrexis\",\"author_id\":1198054,\"on_album\":false,\"album_cover\":null,\"ups\":1,\"downs\":0,\"points\":1,\"datetime\":1450674208,\"parent_id\":540468501,\"deleted\":false,\"vote\":null,\"platform\":\"1\",\"children\":[]}},{\"id\":320338013,\"account_id\":24562464,\"viewed\":false,\"content\":{\"id\":540483269,\"image_id\":\"BJRWQw5\",\"comment\":\"123\",\"author\":\"BigOlHead\",\"author_id\":24295341,\"on_album\":false,\"album_cover\":null,\"ups\":1,\"downs\":0,\"points\":1,\"datetime\":1450651159,\"parent_id\":540468501,\"deleted\":false,\"vote\":null,\"platform\":\"4\",\"children\":[]}}],\"messages\":[{\"id\":322868553,\"account_id\":24562464,\"viewed\":false,\"content\":{\"id\":\"37191085\",\"account_id\":\"24562464\",\"with_account\":\"24562464\",\"spam\":\"0\",\"message_num\":\"17\",\"last_message\":\"Hello World! 25/12/2015 12:27:33\",\"from\":\"imgurapidotnet\",\"datetime\":1451046454}},{\"id\":322866705,\"account_id\":24562464,\"viewed\":false,\"content\":{\"id\":\"37191085\",\"account_id\":\"24562464\",\"with_account\":\"24562464\",\"spam\":\"0\",\"message_num\":\"17\",\"last_message\":\"Hello World! 25/12/2015 12:27:33\",\"from\":\"imgurapidotnet\",\"datetime\":1451046454}},{\"id\":322866577,\"account_id\":24562464,\"viewed\":false,\"content\":{\"id\":\"37191085\",\"account_id\":\"24562464\",\"with_account\":\"24562464\",\"spam\":\"0\",\"message_num\":\"17\",\"last_message\":\"Hello World! 25/12/2015 12:27:33\",\"from\":\"imgurapidotnet\",\"datetime\":1451046454}},{\"id\":322866321,\"account_id\":24562464,\"viewed\":false,\"content\":{\"id\":\"37191085\",\"account_id\":\"24562464\",\"with_account\":\"24562464\",\"spam\":\"0\",\"message_num\":\"17\",\"last_message\":\"Hello World! 25/12/2015 12:27:33\",\"from\":\"imgurapidotnet\",\"datetime\":1451046454}}]},\"success\":true,\"status\":200}";

        public const string MarkNotificationViewed =
            "{\"data\":true,\"success\":true,\"status\":200}";
    }
}