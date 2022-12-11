const fs = require("/Users/havli/Webs/Advent2022/Task 1/text.rtf");


fs.readFile("demo.txt", (err, data) => {
    if (err) throw err;

    console.log(data.toString());
});