function solve(args) {
    let matchAnchorTags = /<a href=".*?">.*?<\/a>/ig,
        matchExtractLable = /<a href="(.*?)">(.*?)<\/a>/,
        matches = [],
        replacementStrings = [];

    matches =
        args[0]
            .match(matchAnchorTags);

    replacementStrings =
        matches
            .map(m => {
                var match = m.match(matchExtractLable);
                return '[' + match[2] + '](' + match[1] + ')';
            });

    let len = matches.length;
    for (let i = 0; i < len; i += 1) {
        args[0] = args[0].replace(matches[i], replacementStrings[i]);
    }

    console.log(args[0]);
}
