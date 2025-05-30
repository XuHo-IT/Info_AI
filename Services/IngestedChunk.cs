﻿using Microsoft.Extensions.VectorData;

namespace MyAiChatApp.Services;

public class IngestedChunk
{
    [VectorStoreRecordKey]
    public required string Key { get; set; }

    [VectorStoreRecordData(IsIndexed = true)]
    public required string DocumentId { get; set; }

    [VectorStoreRecordData]
    public int PageNumber { get; set; }

    [VectorStoreRecordData]
    public required string Text { get; set; }

    [VectorStoreRecordVector(1536, DistanceFunction = DistanceFunction.CosineSimilarity)] // 1536 is the default vector size for the OpenAI text-embedding-3-small model
    public ReadOnlyMemory<float> Vector { get; set; }
}
