"use client";
import { FruitEnum } from "@/app/common/types/enum/FruitEnum";
import { EnumSelect } from "@/app/common/ui/select/EnumSelect";
import { Button } from "@/components/ui/button";
import React from "react";

export default function Page() {
  const [selectedFruit, setSelectedFruit] = React.useState<
    string | undefined
  >();
  return (
    <div className="flex gap-5">
      <EnumSelect
        enumFile={FruitEnum}
        placeholder="Select a fruit"
        value={selectedFruit}
        onChange={setSelectedFruit}
        label="Fruits"
      />
      <Button onClick={() => alert(selectedFruit)}>Submit</Button>
    </div>
  );
}
