using System;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Enums.SafetyEnums;
using VkNet.Model.RequestParams;

namespace LikeBoss
{
    class Like
    {
        string[] Logins, Passwords, Links;
        VkApi vkApi = new VkApi();
        public LikesAddParams likeObject { get; private set; }

        public void LikeUnlike(bool like, int appID, string loginsFile, string linksFile)
        {
            pharseLogins(loginsFile);
            pharsedLinks(linksFile);

            for (int i = 0; i < Logins.Length; i++)
            {
                loginVK(appID, Logins[i], Passwords[i]);

                for (int j = 0; j < Links.Length; j++)
                {
                    if (like)
                    {
                        actLike(likeObjConstructor(Links[j]));
                    }
                    else
                    {
                        actUnlike(likeObjConstructor(Links[j]));
                    }
                }
            }
        }

        private void pharseLogins(string loginsFile)
        {
            string pharseLogins = System.IO.File.ReadAllText(loginsFile);
            string[] loginsAndPasss = pharseLogins.Split(new string[] { "\r" }, StringSplitOptions.RemoveEmptyEntries);

            Logins = new string[loginsAndPasss.Length];
            Passwords = new string[loginsAndPasss.Length];

            for (int i = 0; i < loginsAndPasss.Length; i++)
            {
                string[] localPharsed = loginsAndPasss[i].Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries);
                Logins[i] = localPharsed[0];
                Passwords[i] = localPharsed[1];
            }
        }

        private void pharsedLinks(string linksFile)
        {
            string pharseLinks = System.IO.File.ReadAllText(linksFile);
            Links = pharseLinks.Split(new string[] { "\r" }, StringSplitOptions.RemoveEmptyEntries);
        }

        private void loginVK(int appID, string email, string password)
        {
            vkApi.Authorize(appID, email, password, Settings.All);
        }

        private void actLike(LikesAddParams likeObject)
        {
            vkApi.Likes.Add(likeObject);
        }

        private void actUnlike(LikesAddParams likeObject)
        {
            vkApi.Likes.Delete(likeObject.Type, likeObject.ItemId, likeObject.OwnerId, null, null);
        }

        private LikesAddParams likeObjConstructor(string link)
        {
            LikeObjectType type = LikeObjectType.Photo;
            long itemid = 266486120;
            long ownerid = 2592197;

            // если пост на стене или в сообществе
            if (link.Contains("wall") && !link.Contains("_r"))
            {
                string[] pharsedText = link.Split(new string[] { "wall", "_", "%" }, StringSplitOptions.None);

                type = LikeObjectType.Post;
                itemid = Convert.ToInt64(pharsedText[2]);
                ownerid = Convert.ToInt64(pharsedText[1]);
            }

            // если коммент (не под видео)
            if (link.Contains("_r"))
            {
                string[] pharsedText = link.Split(new string[] { "wall", "_", "r" }, StringSplitOptions.None);

                type = LikeObjectType.Comment;
                itemid = Convert.ToInt64(pharsedText[4]);
                ownerid = Convert.ToInt64(pharsedText[1]);
            }

            // если фото (только прямые url)
            if (link.Contains("photo"))
            {
                string[] pharsedText = link.Split(new string[] { "photo", "_", "%" }, StringSplitOptions.None);

                type = LikeObjectType.Photo;
                itemid = Convert.ToInt64(pharsedText[2]);
                ownerid = Convert.ToInt64(pharsedText[1]);
            }

            // на музыку не смог найти референса, поэтому пофиг

            // если видео (только прямые url)
            if (link.Contains("video"))
            {
                string[] pharsedText = link.Split(new string[] { "video", "_", "%" }, StringSplitOptions.None);

                type = LikeObjectType.Video;
                itemid = Convert.ToInt64(pharsedText[2]);
                ownerid = Convert.ToInt64(pharsedText[1]);
            }

            // если заметка (лучше только прямые url)
            if (link.Contains("note"))
            {
                string[] pharsedText = link.Split(new string[] { "note", "_", "%" }, StringSplitOptions.None);

                type = LikeObjectType.Note;
                itemid = Convert.ToInt64(pharsedText[2]);
                ownerid = Convert.ToInt64(pharsedText[1]);
            }

            // если товар (лучше только прямые url)
            if (link.Contains("product"))
            {
                string[] pharsedText = link.Split(new string[] { "product", "_", "%" }, StringSplitOptions.None);

                type = LikeObjectType.Market;
                itemid = Convert.ToInt64(pharsedText[2]);
                ownerid = Convert.ToInt64(pharsedText[1]);
            }

            return new LikesAddParams
            {
                Type = type,
                ItemId = itemid,
                OwnerId = ownerid
            };
        }
    }
}
