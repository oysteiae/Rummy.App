using Microsoft.AspNetCore.Components.QuickGrid;

namespace Rummy.App.Model
{
    public record PlayerDto
    {
        public const string EmptyChar = "–";
        
        public required string Name { get; init; }

        public int? TwoThreeOfAKindScore { get; set; }
        public string TwoThreeOfAKindScoreString => TwoThreeOfAKindScore?.ToString() ?? EmptyChar;
        public int? OneThreeOfAKindAndOneLadderScore { get; set; }
        public string OneThreeOfAKindAndOneLadderScoreString => OneThreeOfAKindAndOneLadderScore?.ToString() ?? EmptyChar;
        public int? ThreeThreeOfAKindScoreScore { get; set; }
        public string ThreeThreeOfAKindScoreScoreString => ThreeThreeOfAKindScoreScore?.ToString() ?? EmptyChar;
        public int? TwoThreeOfAKindAndOneLadderScore { get; set; }
        public string TwoThreeOfAKindAndOneLadderScoreString => TwoThreeOfAKindAndOneLadderScore?.ToString() ?? EmptyChar;
        public int? OneThreeOfAKindAndTwoLaddersScore { get; set; }
        public string OneThreeOfAKindAndTwoLaddersScoreString => OneThreeOfAKindAndTwoLaddersScore?.ToString() ?? EmptyChar;
        public int? ThreeLaddersScore { get; set; }
        public string ThreeLaddersScoreString => ThreeLaddersScore?.ToString() ?? EmptyChar;

        public int Score =>
            TwoThreeOfAKindScore ?? 0
            + OneThreeOfAKindAndOneLadderScore ?? 0
            + ThreeThreeOfAKindScoreScore ?? 0
            + TwoThreeOfAKindAndOneLadderScore ?? 0
            + OneThreeOfAKindAndTwoLaddersScore ?? 0
            + ThreeLaddersScore ?? 0;
    }
}
