using System.Collections.Generic;

namespace SVG_Creator  {
    public static class Constants  {

        //String to replace in SVG for Back Ground color
        public static string bgColorFill = "bgColor";
        //String to replace in SVG for Skin color
        public static string skinColorFill = "skinColor";

        #region ColorConstants
        public static string lightBlueColor = "#1C8FDF";
        public static string greyColor = "#454545";

        public static string mediumGreyColor = "#8B8C8E";
        public static string pinkColor = "#FBC0A2";
        public static string mediumblueColor = "#5F80B6";
        #endregion

        #region SVG'S
        //SVG Header
        public static string svgHeader = @"<svg width=""819"" height=""1000"" xmlns=""http://www.w3.org/2000/svg"" version=""1.0"" preserveAspectRatio=""xMidYMid meet"">";

        //SVG for background
        public static string backgroundRect = @"<g> <rect id = ""background"" height = ""1300"" width = ""819"" y = ""0"" x = ""0"" stroke = ""black"" fill = ""bgColor""/> </g> ";

        //SVG for Skin
        public static string skin = @"<g> <title>Skin</title> <path d=""M 382 90 C 358.4 93.2 336.3 103.1 318.3 118.4 C 294.7 138.4 282.5 173.7 282.5 222 L 282.5 237.1 L 277.7 241.8 C 272.5 247 270.5 251.8 270.5 259.5 C 270.5 266.9 272.5 272 277.3 276.8 L 290 283 L 294 294 C 292.6 338.2 328.6 383.2 345.6 388.2 C 317.6 379.2 287.6 390.2 272 410 C 283 391 278 372 288 367 C 281 356 274 359 268 382 C 266.9 332.3 265.7 327.1 265 325.3 C 263.5 321.7 259.2 318.5 257.1 319.3 C 256.3 319.6 256 321 254.1 317.5 C 250.9 312.6 245.7 311.9 243.8 316.2 C 243.3 317.3 241.3 318.8 239.5 319.4 C 236.9 320.2 235.8 321.3 235.1 323.7 C 234.5 325.7 233.3 327.1 231.8 327.5 C 227 328.7 226.2 332.5 225.5 358.9 C 225.1 372.4 225.1 386.6 225.6 390.6 C 226.6 399.7 229.8 407.3 234.1 410.8 C 237.1 413.3 237.4 414 236.8 417.2 C 237 422 236 424 236 432 C 234 451.6 233.1 500.5 234 515 C 234.9 523.7 235 525 237 538 C 237 553 247 558 256.2 568 C 265.9 572.6 266 572.6 272.9 565.7 C 280 558.7 283.8 552.5 285.8 544.4 C 287 542 288.7 535 290.3 530.5 C 292.7 523.7 300 499 303 487.2 L 303.8 484.3 L 305.9 487.8 C 309 490 311 496 313 519 C 314.2 534.3 315.9 555.2 316.7 565.4 C 317.9 579.9 318 584.8 317 588.1 C 316.4 590.4 316.1 594.2 316.3 596.6 C 316.6 599.3 315.9 604.2 314.5 609.7 C 308.1 634.3 309.1 652.5 321.1 730.6 C 324.4 751.8 325.1 758.9 325.1 770.9 C 325.1 787 327.7 819.6 332 857.4 C 334.7 881.8 334.7 881.9 332.9 888.4 C 331.9 892 330.8 897.9 330.4 901.7 C 329.9 907.5 329.1 909.5 325 916 C 317.6 927.7 313.9 944.2 317.9 947.6 C 320.1 949.5 329.9 952.7 331.2 951.8 C 331.7 951.5 332.8 951.7 333.6 952.4 C 334.9 953.5 340.8 954.4 349.1 954.8 C 351.6 954.9 354.6 955.5 355.8 956.2 C 359.6 958.3 366.6 957.7 369.9 954.9 C 374 951.5 375.3 945.7 375.2 931.8 C 374.7 887 375 879.8 377.6 861.9 C 385.8 805.1 388.4 774.8 387.3 749.4 C 387.2 747.5 390.4 732.2 394.4 715.4 L 401.6 684.9 L 406.1 684.3 C 408.6 684 411.3 683.4 412.1 683 C 413.4 682.5 414.9 687.6 421.3 715.1 L 429 747.9 L 428.4 760.4 C 427.7 777.1 432.7 827 438.8 864.9 C 440.8 877 441.4 895.4 440.9 931.9 C 440.7 946.7 441.8 951.1 446.2 954.9 C 448.5 956.8 450.4 957.4 454 957.4 C 456.6 957.4 459.2 956.9 459.9 956.2 C 460.5 955.6 463.2 955 465.8 954.9 C 480.6 954.2 496.5 950.2 498.9 946.5 C 500.4 944.4 500.4 943.4 498.9 936.3 C 497.2 928.1 494.2 921.1 489.1 913.3 C 486.8 909.7 486 907 485.2 900.3 C 484.7 895.7 483.5 889.8 482.7 887.3 C 481.2 883 481.3 881.2 483.6 860.4 C 488.2 819.1 490.2 796 490.7 774.9 C 491.2 757.1 492 749.5 495.7 724.9 C 503.5 672.7 505.2 657.1 505 636.4 L 503 620 c 1 -15 -7 -38 7 -128 C 517 509.3333 524 526.6667 531 544 C 543 535 561 531 577 527 C 569.6667 504 562.3333 481 545 433 C 541 427 539 389 476 384 C 528 349 517 286 525 281 C 549 281 547 247 540.4 243 C 536.3 239.1 536 239 536 212.8 C 535.9 190.4 535.6 185 533.8 176.5 C 528.8 152.6 520.7 136.2 507.1 122.2 C 488.8 103.2 460.5 91 425.1 89.1 Z M 424 90 L 424 90 L 382 90 Z M 348 388 C 350 390 363 397 378 400 C 415 409 437 401 441 400 C 449 398 466 394 475 386 M 285 544 C 293 518 272 463 268 409 C 262 412 261 409 256 411 C 249 413 247 411 239 410 M 269 407 M 235 366 L 234 327 M 247 363 L 245 317 m 12 44 L 256 321 Z"" stroke-width=""3"" stroke=""#1A6BA0"" fill=""skinColor"" id=""SkinPath""/></g>";

        //SVG for Hair
        public static string hair = @"<g> <path d=""M 284 270 C 271 173 296 141 324 115 C 388 64 475 98 499 114 C 552 156 536 222 529 276 C 526 281 522 279 519 278 C 517.3333 263.3333 521 248 514 234 C 495 225 493 213 480 197 C 474 194 469 194 463 194 C 441.6667 195 420 199 399 197 C 381 196 359 189 347 191 C 335 195 334.3333 203.6667 328 210 C 322 217 314 226 305 226 C 293 240 296 261 297 272 C 295 274 287 275 286 273 Z"" stroke-width=""5"" stroke=""black"" fill=""black"" id=""Hair""/></g>";

        //SVG for Dress Konan
        public static string konagam = @"<g> <title>Dress</title> <path d=""M 318 583 C 349 584 385 605 501 584 L 502 602 C 451 615 373 619 316 602 C 312 594 316 589 318 583 M 356 611 C 374 633 391 656 394 683 C 399 687 406 686 411 683 C 419 658 434 634 445 612 C 413 613 390 614 355 610 Z"" stroke-width=""1"" stroke=""black"" fill=""brown"" id=""Dress""/> </g>";

        //SVG for Dress Pattethodap
        public static string pattethodap =
            @"<g> <title>NewDress</title> <path d=""M 317 583 C 342 581 480 588 503 583 C 521 634 498 710 499 713 C 493 756 500 808 483 852 C 448 843 422 764 405 723 C 395 779 358 853 326 848 C 316 797 312 759 310 704 C 309 704 290 615 316 584 Z"" stroke-width=""1"" stroke=""black"" fill=""Red"" id=""NewDress"" /> " +
            @"<path d = "" M 312 739 C 343 735 372 717 397 704 M 316 776 C 352 771 372 741 396 721 M 322 817 C 348 804 375 774 398 731 M 496 737 C 468 732 438 719 416 706 M 496 776 C 465 767 437 742 413 720 M 491 816 C 459 796 432 762 414 729 Z"" stroke-width=""1"" stroke=""black"" fill=""gold"" id=""NewDress"" />" +
            @"<path d = "" M 387 618 L 361 731 C 398 763 408 761 443 730 L 416 619 Z"" stroke-width=""1"" stroke=""black"" fill=""gold"" id=""NewDress"" />" +
            @"<path d = "" M 396 628 L 377 730 M 405 629 L 403 737 M 412 628 L 426 733Z"" stroke-width=""1"" stroke=""black"" fill=""gold"" id=""NewDress"" />" +
            @"<path d = ""M 317 583 C 368 581 412 586 503 583 L 510 604 C 504 618 489 620 468 601 C 466 616 448 641 423 607 C 415 651 385 634 382 603 C 390 617 352 637 344 599 C 343 625 302 616 317 584 Z"" stroke-width=""1"" stroke=""black"" fill=""gold"" id=""NewDress"" /> " +
            @"<path d = ""M 325 600 A 1 1 0 0 0 332 603 A 1 1 0 0 0 325 600 M 362 608 A 1 1 0 0 0 370 608 A 1 1 0 0 0 362 608 M 400 620 A 1 1 0 0 0 408 621 A 1 1 0 0 0 400 620 M 445 615 A 1 1 0 0 0 453 613 A 1 1 0 0 0 445 615 M 493 606 A 1 1 0 0 0 501 605 A 1 1 0 0 0 493 606 Z"" stroke-width=""1"" stroke=""black"" fill=""red"" id=""NewDress"" /> " +
            @"</g>";

        //Face SVG
        public static string happyFace =
            @"<g>" +
            @"<title> Face </title>" +
            @"<path d=""M 330 276 A 1 1 0 0 0 372 279 A 1 1 0 0 0 330 273 Z"" stroke-width=""1"" stroke=""#1C8FDF"" fill=""black"" id=""LeftEye"" />" +
            @"<path d = ""M 350 268 A 1 1 0 0 0 364 268 A 1 1 0 0 0 350 267 Z"" stroke-width=""1"" stroke=""#1C8FDF"" fill=""white"" id=""LeftEyeInside"" />" +
            @"<path d = ""M 443 276 A 1 1 0 0 0 485 276 A 1 1 0 0 0 443 275 Z"" stroke-width=""1"" stroke=""#1C8FDF"" fill=""black"" id=""RightEye"" />" +
            @"<path d = ""M 463 268 A 1 1 0 0 0 478 266 A 1 1 0 0 0 463 267 Z"" stroke-width=""1"" stroke=""#1C8FDF"" fill=""white"" id=""RightEyeInside"" />" +
            @"<path d=""M 496 261 C 488 254 475 241 449 247 L 447 234 C 495 234 495 261 496 261"" stroke-width=""1"" stroke=""#1C8FDF"" fill=""black"" id=""RightEyeBrow"" />"+
            @"<path d = ""M 321 262 C 326 259 332 244 369 247 L 369 234 C 330 237 325 251 321 262"" stroke-width=""1"" stroke=""#1C8FDF"" fill=""black"" id=""LeftEyeBrow"" />"+
            @"<path d = ""M 443 351 C 445 357 443 358 441 359 C 441 360 392 363 373 355 C 372 353 372 351 374 349 C 395 353 423 355 443 351"" fill=""#1A6BA0"" id=""UpperLip"" />"+
            @"<path d = ""M 386 360 C 381 360 382 365 383 366 C 384 369 395 375 410 375 C 423 374 426 371 429 369 C 431 367 431 364 431 363 C 431 360 428 361 426 362 C 425 362.6667 424 364.3333 422 366 C 414 368 404 370 394 366 C 391.3333 364 388.6667 362 386 360"" fill=""#1A6BA0"" id=""LowerLip"" />"+
            @"</g>";

        //Face SVG
        public static string monkeyFace =
            @"<g>" +
            @"<title> Face </title>" +
            @"<path d=""M 330 276 A 1 1 0 0 0 372 279 A 1 1 0 0 0 330 273 Z"" stroke-width=""1"" stroke=""#1C8FDF"" fill=""black"" id=""LeftEye"" />" +
            @"<path d = ""M 350 268 A 1 1 0 0 0 364 268 A 1 1 0 0 0 350 267 Z"" stroke-width=""1"" stroke=""#1C8FDF"" fill=""white"" id=""LeftEyeInside"" />" +
            @"<path d = ""M 443 276 A 1 1 0 0 0 485 276 A 1 1 0 0 0 443 275 Z"" stroke-width=""1"" stroke=""#1C8FDF"" fill=""black"" id=""RightEye"" />" +
            @"<path d = ""M 463 268 A 1 1 0 0 0 478 266 A 1 1 0 0 0 463 267 Z"" stroke-width=""1"" stroke=""#1C8FDF"" fill=""white"" id=""RightEyeInside"" />" +
            @"<path d=  ""M 496 261 C 488 254 475 241 449 247 L 447 234 C 495 234 495 261 496 261Z"" stroke-width=""1"" stroke=""#1C8FDF"" fill=""black"" id=""RightEyeBrow"" />" +
            @"<path d = ""M 321 262 C 326 259 332 244 369 247 L 369 234 C 330 237 325 251 321 262Z"" stroke-width=""1"" stroke=""#1C8FDF"" fill=""black"" id=""LeftEyeBrow"" />" +
            @"<path d = ""M 383 329 L 434 328 C 441 329 469 335 463 359 C 463 365 460 386 436 392 C 428 393 421 394 412 391 C 402 394 395 394 387 393 C 365 390 356 368 356 350 C 357 345 361 331 383 329Z"" fill=""pink"" id=""UpperLip"" />" +
            @"<path d = ""M 363 351 C 383 360 397 354 409 351 C 436 358 444 356 457 347 C 443 370 421 359 410 356 C 392 364 374 360 363 351 Z"" fill=""brown"" id=""LowerLip"" />" +
            @"<path d = ""M 394 315 C 401 312 408 321 407 324 C 402 321 392 320 394 315 Z M 412 324 C 414 320 416 314 424 316 C 426 322 416 320 412 324 Z"" fill=""brown"" id=""Nose"" />" +
            @"<path d = ""M 530 405 C 542 367 557 324 584 291 C 607 265 617 278 622 296 L 614 300 C 614 276 593 290 591 298 C 568 329 549 374 538 416 Z"" stroke-width=""3"" stroke=""#1A6BA0"" fill=""skinColor"" id=""Tail"" />" +
            @"<path d = ""M 614 300 C 608 303 611 325 621 340 C 619 310 629 312 623 296"" fill=""brown"" id=""TailHair"" />" +
            @"</g>";

        //Crown SVG
        public static string crown =
            @"<g>" +
            @"<title>Crown</title>" +
            @"<path d = ""M 281 247 C 251 93 327 58 411 39 C 551 54 555 190 537 244 C 450 181 304 210 281 247 Z"" stroke-width=""1"" stroke=""black"" fill=""Gold"" id=""Crown""/>" +
            @"<path d = ""M 294 234 C 285 207 288 106 366 71 M 320 221 C 325 176 324 123 376 77 M 369 209 C 371 169 380 125 393 81 M 443 207 C 439 169 438 124 422 82 M 497 222 C 494 178 494 120 439 79 M 527 236 C 542 141 483 88 452 76 C 428 80 398 89 368 70 C 370.6667 67 373.3333 64 376 61 C 399 70 422 67 441 62 C 444.6667 65.6667 450 68 452 75 M 443 62 C 450 50 438 43 426 37 C 416 38 406 38 396 37 C 378 44 374 53 376 61 M 396 37 C 393 28 405.3333 12.3333 411 -1 C 419 13 427 30 426 37 Z"" stroke-width=""1"" stroke=""black"" fill=""Gold"" id=""Crown""/>" +
            @"<path d = ""M 295 234 C 292 223 284 205 292 196 C 296 178 311 174 320 171 C 332 151 351 147 364 145 C 367 141 384 119 405 117 C 424 120 441 136 445 142 C 476 149 493 167 499 173 C 537 194 534 221 527 236 c -27 -18 -144 -54 -232 -2 Z "" stroke-width=""1"" stroke=""black"" fill=""Gold"" id=""Crown""/>" +
            @"<path d = ""M 309 198 A 1 1 0 0 0 321 199 A 1 1 0 0 0 309 198 M 352 187 A 1 1 0 0 0 363 184 A 1 1 0 0 0 352 186 M 405 183 C 396 183 390 161 406 140 C 419 160 415 185 405 183 M 453 185 A 1 1 0 0 0 464 184 A 1 1 0 0 0 453 185 M 498 199 A 1 1 0 0 0 509 199 A 1 1 0 0 0 498 199 Z "" stroke-width=""1"" stroke=""black"" fill=""Red"" id=""Crown""/>" +
            @"</g>";

        //Weapon SVG
        public static string yogaDanda =
            @"<g>" +
            @"<title>Weapon</title>" +
            @"<path d = ""M 482 709 L 391 596 C 364 606 361 585 355 584 C 351 583 347 584 342 583 L 356 572 C 354 568.6667 367 572 374 581 C 380 586 388 587 394 586 C 401 574 393 562 388 550 C 387 547 388 545 390 543 L 400 536 L 401 545 L 410 560 C 410 566 415 576 402 587 L 402 593 L 490 699 C 493 709 481 710 485 709 Z"" stroke-width=""1"" stroke=""black"" fill=""Brown"" id=""Weapon"" />" +
            @"</g>";

        public static string mace =
            @"<g>" +
            @"<title>Mace</title>" +
            @"<path d = ""M 488 698 L 412 594 A 1 1 0 0 0 353 545 A 1 1 0 0 0 393 607 L 477 707 Z M 361 538 A 1 1 0 0 0 346 551 Z M 346 551 C 346 587 365 599 391 606 M 361 538 M 353 546 L 402 600 M 412 594 C 411 568 397 543 361 538 M 477 707 A 1 1 0 0 0 488 698 Z"" stroke-width=""1"" stroke=""black"" fill=""Gold"" id=""Mace"" />" +
            @"</g>";

        //Hand Cover
        public static string handCover =
            @"<g>" +
            @"<title>HandCover</title>" +
            @"<path d = ""M 418 632 C 422 627 428 621 431 618 C 430 614 413 612 419 596 C 436 604 458 598 472 625 C 473 628 474 630 474 633 C 469 647 461 657 441 664 C 429 657 419 644 416 636 Z"" stroke-width=""3"" stroke=""#1A6BA0"" fill=""skinColor"" id=""HandCover"" />" +
            @"<path d = ""M 471 599 C 491.6667 581 512.3333 563 533 545 C 546 535 562 530 575 524 l 8 30 C 580 570 563 583 474 633 L 459 610 Z"" stroke-width=""3"" stroke=""#1A6BA0"" fill=""skinColor"" id=""HandCover"" />" +
            @"<path d = ""M 554 532 l 20 -8 Z"" stroke-width=""7"" stroke=""skinColor"" fill=""skinColor"" id=""HandCover"" />" +
            @"</g>";
        //SVG Footer
        public static string svgFooter = @"</svg>";

        #endregion

        #region Gene Map
        //Background color map
        public static Dictionary<int, Traits> bgColorMap = new Dictionary<int, Traits>(5);

        //Skin COlor map
        public static Dictionary<int, Traits> skinColorMap = new Dictionary<int, Traits>(5);

        //Dress map
        public static Dictionary<int, Traits> dressMap = new Dictionary<int, Traits>(2);

        //Weapon map
        public static Dictionary<int, Traits> weaponMap = new Dictionary<int, Traits>(2);

        //Face map
        public static Dictionary<int, Traits> faceMap = new Dictionary<int, Traits>(2);

        //Crown map
        public static Dictionary<int, Traits> crownMap = new Dictionary<int, Traits>(2);

        #endregion
        static Constants() {

            //Create trait map
            //TODO create from JSON File

            //Create map of Background color
            bgColorMap.Add(0, new Traits(){Gene="BgColor",Index=0,Name = "BlueBackground",SVG = lightBlueColor });
            bgColorMap.Add(1, new Traits(){ Gene = "BgColor", Index = 1, Name = "BrownBackground", SVG = greyColor });

            //Create map of Skin Color
            skinColorMap.Add(0, new Traits() { Gene = "SkinColor", Index = 0, Name = "RamaSkin", SVG = lightBlueColor });
            skinColorMap.Add(1, new Traits() { Gene = "SkinColor", Index = 1, Name = "ShivaSkin", SVG = mediumGreyColor });
            skinColorMap.Add(2, new Traits() { Gene = "SkinColor", Index = 2, Name = "HumanSkin", SVG = pinkColor });
            skinColorMap.Add(3, new Traits() { Gene = "SkinColor", Index = 3, Name = "KrishnaSkin", SVG = mediumblueColor });

            //Create map of Dress
            dressMap.Add(0, new Traits() { Gene = "Dress", Index = 0, Name = "Konagam", SVG = konagam ,Description = "True ascetic should not wear anything other than Langot" });
            dressMap.Add(1, new Traits() { Gene = "Dress", Index = 1, Name = "Pattethodap", SVG = pattethodap, Description = "This attire showcases an ethnic blend of tradition and modernity" });

            //Create map of Weapon
            weaponMap.Add(0, new Traits() { Gene = "Weapon", Index = 0, Name = "YogaStick", SVG = yogaDanda ,Description = "The Meditation Stick is a very ancient and traditional yoga tool to assist in one's spiritual practice" });
            weaponMap.Add(1, new Traits() { Gene = "Weapon", Index = 1, Name = "Mace", SVG = mace, Description = "The gada is the main weapon of the Hindu God Hanuman, wielding Gada means you are very strong" });

            //Create map of Face
            faceMap.Add(0, new Traits() { Gene = "Face", Index = 0, Name = "HumanHappyFace", SVG = happyFace });
            faceMap.Add(1, new Traits() { Gene = "Face", Index = 1, Name = "MonketHappyFace", SVG = monkeyFace });

            //Create map of Crown
            crownMap.Add(0, new Traits() { Gene = "Crown", Index = 0, Name = "NoCrown", SVG = string.Empty });
            crownMap.Add(1, new Traits() { Gene = "Crown", Index = 1, Name = "GoldenCrown", SVG = crown });

        }
    }
}
